using System;
using System.Threading.Tasks;

using R5T.T0132;
using R5T.T0172.Extensions;
using R5T.T0195.Extensions;


namespace R5T.S0066
{
    [FunctionalityMarker]
    public partial interface IProjectScripts : IFunctionalityMarker
    {
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
