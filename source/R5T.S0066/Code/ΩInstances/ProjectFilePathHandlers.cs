using System;


namespace R5T.S0066
{
    public class ProjectFilePathHandlers : IProjectFilePathHandlers
    {
        #region Infrastructure

        public static IProjectFilePathHandlers Instance { get; } = new ProjectFilePathHandlers();


        private ProjectFilePathHandlers()
        {
        }

        #endregion
    }
}
