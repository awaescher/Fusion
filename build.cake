#addin "Cake.FileHelpers"
#tool "nuget:?package=OpenCover"
#tool "nuget:?package=NUnit.ConsoleRunner"
#tool "nuget:?package=GitVersion.CommandLine&version=4.0.0"

///////////////////////////////////////////////////////////////////////////////
// ARGUMENTS
///////////////////////////////////////////////////////////////////////////////

var target = Argument<string>("target", "Default");
var configuration = Argument<string>("configuration", "Release");
var netcoreTargetFramework = Argument<string>("targetFrameworkNetCore", "net6.0-windows");

///////////////////////////////////////////////////////////////////////////////
// GLOBAL VARIABLES
///////////////////////////////////////////////////////////////////////////////

var _solution = $"./Fusion++.sln";
var _appVersion = "";
var _outputDir = Directory($"_output");
var _testOutputDir = Directory($"_testOutput");
	
///////////////////////////////////////////////////////////////////////////////
// TASK DEFINITIONS
///////////////////////////////////////////////////////////////////////////////

Setup(context =>
{
	EnsureDirectoryExists(_outputDir);
	CleanDirectory(_outputDir);
	EnsureDirectoryExists(_testOutputDir);
	CleanDirectory(_testOutputDir);
});

Task("Clean")
    .Description("Cleans all directories that are used during the build process.")
    .Does(() =>
{
	CleanDirectories("./**/bin/" + configuration);
	CleanDirectories("./**/obj/" + configuration);
});

Task("Restore")
    .Description("Restores all the NuGet packages that are used by the specified solution.")
    .Does(() =>
{
	Information("Restoring {0}...", _solution);
	NuGetRestore(_solution);
});

Task("SetVersion")
	.IsDependentOn("Restore")
   	.Does(() => 
	{
		var gitVersion = GitVersion(new GitVersionSettings
		{
			UpdateAssemblyInfo = true
		});
		
		_appVersion = $"{gitVersion.Major}.{gitVersion.Minor}" + (gitVersion.Patch == 0 ? "" : $".{gitVersion.Patch}");
		var fullVersion = gitVersion.AssemblySemVer;
		
		ReplaceRegexInFiles("./**/*.csproj", "(?<=<AssemblyVersion>).*?(?=</AssemblyVersion>)", _appVersion);
		ReplaceRegexInFiles("./**/*.csproj", "(?<=<Version>).*?(?=</Version>)", fullVersion);
		ReplaceRegexInFiles("./**/*.csproj", "(?<=<FileVersion>).*?(?=</FileVersion>)", fullVersion);

		Information($"AppVersion:\t{_appVersion}");
		Information($"FullVersion:\t{fullVersion}");
	});

Task("Build")
    .Description("Builds all the different parts of the project.")
    .IsDependentOn("Clean")
    .IsDependentOn("Restore")
	.IsDependentOn("SetVersion")
    .Does(() =>
{
	Information("Building {0} for tests", _solution);

	// just for tests, not the app itself
	MSBuild(_solution, settings =>
		settings.SetPlatformTarget(PlatformTarget.MSIL)
			.SetMSBuildPlatform(MSBuildPlatform.x64)
			.UseToolVersion(MSBuildToolVersion.VS2019)
			.WithTarget("Build")
			.SetConfiguration(configuration));
});

Task("Test")
	.IsDependentOn("Build")
	.Does(() => 
{
	var assemblies = new[] 
	{
		$"./Fusion++.Tests/bin/{configuration}/Fusion++.Tests.dll"
	};
	
	var testResultsFile = MakeAbsolute(File($"{_testOutputDir}/TestResults.xml")).FullPath;
	var testCoverageFile = MakeAbsolute(File($"{_testOutputDir}/TestCoverage.xml")).FullPath;
	
	Information("Test results xml:  " + testResultsFile);
	Information("Test coverage xml: " + testCoverageFile);
	
	var openCoverSettings = new OpenCoverSettings()
		.WithFilter("+[*]*")
		.WithFilter("-[Specs]*")
		.WithFilter("-[Tests]*")
		.WithFilter("-[FluentAssertions*]*")
		.WithFilter("-[Moq*]*");
		
	openCoverSettings.ReturnTargetCodeOffset = 0;

	var nunitSettings = new NUnit3Settings
	{
		Results = new[]
		{
			new NUnit3Result { FileName = testResultsFile }
		},
		NoHeader = true,
		Configuration = "Default"             
	};
	
	OpenCover(tool => tool.NUnit3(assemblies, nunitSettings),
		new FilePath(testCoverageFile),
		openCoverSettings
	);
});

Task("Publish")
	.IsDependentOn("Build")
	.IsDependentOn("Test")
	.Does(() => 
{
	var settings = new DotNetCorePublishSettings
	{
		Framework = netcoreTargetFramework,
		Configuration = configuration,
		Runtime = "win-x64",
		SelfContained = false
	};
	DotNetCorePublish("./Fusion++/Fusion++.csproj", settings);

	// files are published to Fusion++\bin\Release\netcoreapp3.1\win-x64\publish
	CopyFiles($"./Fusion++/bin/{configuration}/{netcoreTargetFramework}/{settings.Runtime}/publish/**/*", _outputDir, true);

	foreach (var extension in new string[]{"pdb", "config", "xml"})
		DeleteFiles(_outputDir.Path + "/*." + extension);
});

Task("Pack")
	.IsDependentOn("Publish")
	.Does(() => 
{	
	// get the app files BEFORE adding additional packed ones
	var appFiles = GetFiles($"{_outputDir}/**/*");

	ReplaceTextInFiles("_choco/fusionplusplus.nuspec", "{PRODUCT_VERSION}", _appVersion);
	
	var settings = new ChocolateyPackSettings()
	{
		OutputDirectory = _outputDir,
		Authors = { "Andreas Wäscher" },
		Tags = { "fusion", "assembly", "FUSLOGVW", "binding", "foss", "utilities", "productivity" },
		Version = _appVersion
	};
	
	ChocolateyPack("_choco/fusionplusplus.nuspec", settings);
	
	Zip(_outputDir.Path, _outputDir.Path + $"/Fusion++ {_appVersion}.zip", appFiles);

});

///////////////////////////////////////////////////////////////////////////////
// TARGETS
///////////////////////////////////////////////////////////////////////////////

Task("Default")
    .Description("This is the default task which will be ran if no specific target is passed in.")
    .IsDependentOn("Pack");

///////////////////////////////////////////////////////////////////////////////
// EXECUTION
///////////////////////////////////////////////////////////////////////////////

RunTarget(target);