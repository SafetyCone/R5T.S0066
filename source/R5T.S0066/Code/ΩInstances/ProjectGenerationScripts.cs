using System;


namespace R5T.S0066
{
    public class ProjectGenerationScripts : IProjectGenerationScripts
    {
        #region Infrastructure

        public static IProjectGenerationScripts Instance { get; } = new ProjectGenerationScripts();


        private ProjectGenerationScripts()
        {
        }

        #endregion
    }
}
