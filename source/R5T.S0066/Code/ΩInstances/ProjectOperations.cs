using System;


namespace R5T.S0066
{
    public class ProjectOperations : IProjectOperations
    {
        #region Infrastructure

        public static IProjectOperations Instance { get; } = new ProjectOperations();


        private ProjectOperations()
        {
        }

        #endregion
    }
}
