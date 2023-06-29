using System;


namespace R5T.S0066
{
    public class ProjectContextOperations : IProjectContextOperations
    {
        #region Infrastructure

        public static IProjectContextOperations Instance { get; } = new ProjectContextOperations();


        private ProjectContextOperations()
        {
        }

        #endregion
    }
}
