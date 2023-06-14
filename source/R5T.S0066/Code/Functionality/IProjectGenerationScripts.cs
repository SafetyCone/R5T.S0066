using System;
using System.Threading.Tasks;

using R5T.F0000;
using R5T.L0038;
using R5T.T0132;
using R5T.T0198;


namespace R5T.S0066
{
    [FunctionalityMarker]
    public partial interface IProjectGenerationScripts : IFunctionalityMarker
    {
        public async Task Create_BlazorClientProject()
        {
            /// Inputs.
            var projectName = Instances.Values.Sample_ProjectName;
            var projectDescription = Instances.Values.Sample_ProjectDescription;
            var solutionDirectoryPath = Instances.Paths.Sample_SolutionDirectoryPath;
            var repositoryUrl = new IsSet<IRepositoryUrl>();


            /// Run.
            var (humanOutputTextFilePath, logFilePath) = await Instances.ApplicationContextOperator.In_ApplicationContext_Undated(
                Instances.Values.ApplicationName,
                ApplicationContextOperation);

            async Task ApplicationContextOperation(IApplicationContext applicationContext)
            {
                await Instances.ProjectContextOperator.In_ProjectContext(
                    projectName,
                    solutionDirectoryPath,
                    applicationContext.TextOutput,
                    Instances.ProjectContextOperations.Create_BlazorClient(
                        projectDescription,
                        repositoryUrl,
                        Instances.ProjectFilePathHandlers.Default
                    )
                );
            }

            Instances.WindowsExplorerOperator.OpenDirectoryInExplorer(
                solutionDirectoryPath.Value);
        }

        public async Task Create_WebServerForBlazorClientProject()
        {
            /// Inputs.
            var projectName = Instances.Values.Sample_ProjectName;
            var projectDescription = Instances.Values.Sample_ProjectDescription;
            var solutionDirectoryPath = Instances.Paths.Sample_SolutionDirectoryPath;
            var repositoryUrl = new IsSet<IRepositoryUrl>();
            var clientProjectFilePath = Instances.Paths.Example_ProjectFilePath;


            /// Run.
            var (humanOutputTextFilePath, logFilePath) = await Instances.ApplicationContextOperator.In_ApplicationContext_Undated(
                Instances.Values.ApplicationName,
                ApplicationContextOperation);

            async Task ApplicationContextOperation(IApplicationContext applicationContext)
            {
                await Instances.ProjectContextOperator.In_ProjectContext(
                    projectName,
                    solutionDirectoryPath,
                    applicationContext.TextOutput,
                    Instances.ProjectContextOperations.Create_WebServerForBlazorClient(
                        projectDescription,
                        repositoryUrl,
                        clientProjectFilePath,
                        Instances.ProjectFilePathHandlers.Default
                    )
                );
            }

            Instances.WindowsExplorerOperator.OpenDirectoryInExplorer(
                solutionDirectoryPath.Value);
        }

        public async Task Create_ConsoleProject()
        {
            /// Inputs.
            var projectName = Instances.Values.Sample_ProjectName;
            var projectDescription = Instances.Values.Sample_ProjectDescription;
            var solutionDirectoryPath = Instances.Paths.Sample_SolutionDirectoryPath;
            var repositoryUrl = new IsSet<IRepositoryUrl>();


            /// Run.
            var (humanOutputTextFilePath, logFilePath) = await Instances.ApplicationContextOperator.In_ApplicationContext_Undated(
                Instances.Values.ApplicationName,
                ApplicationContextOperation);

            async Task ApplicationContextOperation(IApplicationContext applicationContext)
            {
                await Instances.ProjectContextOperator.In_ProjectContext(
                    projectName,
                    solutionDirectoryPath,
                    applicationContext.TextOutput,
                    Instances.ProjectContextOperations.Create_ConsoleProject(
                        projectDescription,
                        repositoryUrl,
                        Instances.ProjectFilePathHandlers.Default
                    )
                );
            }

            Instances.WindowsExplorerOperator.OpenDirectoryInExplorer(
                solutionDirectoryPath.Value);
        }

        public async Task Create_LibraryProject()
        {
            /// Inputs.
            var projectName = Instances.Values.Sample_ProjectName;
            var projectDescription = Instances.Values.Sample_ProjectDescription;
            var solutionDirectoryPath = Instances.Paths.Sample_SolutionDirectoryPath;
            var repositoryUrl = new IsSet<IRepositoryUrl>();


            /// Run.
            var (humanOutputTextFilePath, logFilePath) = await Instances.ApplicationContextOperator.In_ApplicationContext_Undated(
                Instances.Values.ApplicationName,
                ApplicationContextOperation);

            async Task ApplicationContextOperation(IApplicationContext applicationContext)
            {
                await Instances.ProjectContextOperator.In_ProjectContext(
                    projectName,
                    solutionDirectoryPath,
                    applicationContext.TextOutput,
                    Instances.ProjectContextOperations.Create_LibraryProject(
                        projectDescription,
                        repositoryUrl,
                        Instances.ProjectFilePathHandlers.Default
                    )
                );
            }

            Instances.WindowsExplorerOperator.OpenDirectoryInExplorer(
                solutionDirectoryPath.Value);
        }
    }
}
