#load nuget:https://www.myget.org/F/cake-contrib/api/v2?package=Cake.Recipe&prerelease

Environment.SetVariableNames();

BuildParameters.SetParameters(context: Context, 
                            buildSystem: BuildSystem,
                            sourceDirectoryPath: "./Source",
                            title: "Cake.Coveralls",
                            repositoryOwner: "cake-contrib",
                            repositoryName: "Cake.Coveralls",
                            appVeyorAccountName: "cakecontrib",
                            webHost: "cake-contrib.github.io",
                            webLinkRoot: "Cake.Coveralls",
                            webBaseEditUrl: "https://github.com/cake-contrib/Cake.Coveralls/tree/develop/docs/input/");

BuildParameters.PrintParamters(Context);

ToolSettings.SetToolSettings(context: Context,
                            dupFinderExcludePattern: new string[] { 
                                BuildParameters.RootDirectoryPath + "/Source/Cake.Coveralls.Tests/*.cs" },
                            testCoverageFilter: "+[*]* -[xunit.*]* -[Cake.Core]* -[Cake.Testing]* -[*.Tests]* ",
                            testCoverageExcludeByAttribute: "*.ExcludeFromCodeCoverage*",
                            testCoverageExcludeByFile: "*/*Designer.cs;*/*.g.cs;*/*.g.i.cs");

Build.Run();
