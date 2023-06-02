using System;


namespace R5T.S0066
{
    public class ProjectScripts : IProjectScripts
    {
        #region Infrastructure

        public static IProjectScripts Instance { get; } = new ProjectScripts();


        private ProjectScripts()
        {
        }

        #endregion
    }
}
