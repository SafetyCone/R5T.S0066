using System;


namespace R5T.S0066
{
    public static class Instances
    {
        public static F0000.IActionOperations ActionOperations => F0000.ActionOperations.Instance;
        public static L0038.IApplicationContextOperator ApplicationContextOperator => L0038.ApplicationContextOperator.Instance;
        public static F0033.INotepadPlusPlusOperator NotepadPlusPlusOperator => F0033.NotepadPlusPlusOperator.Instance;
        public static IPaths Paths => S0066.Paths.Instance;
        public static L0040.F000.IProjectContextOperator ProjectContextOperator => L0040.ProjectContextOperator.Instance;
        public static IProjectContextOperations ProjectContextOperations => S0066.ProjectContextOperations.Instance;
        public static L0033.IProjectFileContextOperations ProjectFileContextOperations => L0033.ProjectFileContextOperations.Instance;
        public static IProjectFilePathHandlers ProjectFilePathHandlers => S0066.ProjectFilePathHandlers.Instance;
        public static Z0045.Raw.IProjectFileReferences ProjectFileReferences_Raw => Z0045.Raw.ProjectFileReferences.Instance;
        public static IProjectOperations ProjectOperations => S0066.ProjectOperations.Instance;
        public static O0011.O001.ISampleProjectOperations SampleProjectOperations => O0011.O001.SampleProjectOperations.Instance;
        public static IValues Values => S0066.Values.Instance;
        public static F0088.IVisualStudioOperator VisualStudioOperator => F0088.VisualStudioOperator.Instance;
        public static F0034.IWindowsExplorerOperator WindowsExplorerOperator => F0034.WindowsExplorerOperator.Instance;
    }
}