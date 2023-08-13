using System;
using System.Threading.Tasks;

using R5T.F0000;
using R5T.L0031.Extensions;
using R5T.L0038;
using R5T.T0132;
using R5T.T0172.Extensions;
using R5T.T0198;


namespace R5T.S0066
{
    [FunctionalityMarker]
    public partial interface IProjectScripts : IFunctionalityMarker
    {
        public async Task In_New_SampleProjectContext()
        {
            var projectDescription = Instances.Values.Sample_ProjectDescription;
            var repositoryUrl = new IsSet<IRepositoryUrl>();

            var (humanOutputTextFilePath, logFilePath) = await Instances.ApplicationContextOperator.In_ApplicationContext_Undated(
                Instances.Values.ApplicationName,
                ApplicationContextOperation);

            async Task ApplicationContextOperation(IApplicationContext applicationContext)
            {
                await Instances.SampleProjectOperations.In_New_SampleProjectContext(
                    applicationContext.TextOutput,
                    async projectContext =>
                    {
                        //// Just create a simple project file.
                        //await Instances.ProjectContextOperations.Create_New_Project(
                        //    Instances.ActionOperations.Combine_Asynchronously(
                        //        Instances.ProjectFileContextOperations.Setup_ProjectFile_WithLibraryBaseOperations()
                        //    ),
                        //    Instances.ActionOperations.DoNothing,
                        //    Instances.ActionOperations.DoNothing
                        //    )
                        //    (projectContext);

                        await projectContext.Run(
                            Instances.ProjectContextOperations.Create_RazorClassLibrary(
                                projectDescription,
                                repositoryUrl)
                        );

                        Instances.VisualStudioOperator.Open_ProjectFile(
                            projectContext.ProjectFilePath.Value);
                    });
            }

            Instances.NotepadPlusPlusOperator.Open(
                humanOutputTextFilePath,
                logFilePath);
        }

        public async Task AddProjectReferences()
        {
            /// Inputs.
            var projectFilePath =
                @""
                .ToProjectFilePath()
                ;
            var projectFileReferences =
                //Instances.ProjectFileReferenceSets.For_ContextTypeDefinitionLibrary
                new[]
                {
                    //@"".ToProjectFileReference(),
                    //Instances.ProjectFileReferences.For_NET_6_FoundationLibrary,
                    Instances.ProjectFileReferences_Raw.R5T_F0020,
                    Instances.ProjectFileReferences_Raw.R5T_F0056,
                }
                ;


            /// Run.
            await Instances.ProjectOperations.Add_ProjectReferences(
                projectFilePath,
                projectFileReferences);
        }
    }
}
