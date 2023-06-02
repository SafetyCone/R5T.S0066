using System;


namespace R5T.S0066
{
    public static class Instances
    {
        public static L0038.IApplicationContextOperator ApplicationContextOperator => L0038.ApplicationContextOperator.Instance;
        public static F0033.INotepadPlusPlusOperator NotepadPlusPlusOperator => F0033.NotepadPlusPlusOperator.Instance;
        public static IPaths Paths => S0066.Paths.Instance;
        public static L0040.F000.IProjectContextOperator ProjectContextOperator => L0040.ProjectContextOperator.Instance;
        public static O0010.IProjectContextOperations ProjectContextOperations => O0010.ProjectContextOperations.Instance;
        public static IProjectFilePathHandlers ProjectFilePathHandlers => S0066.ProjectFilePathHandlers.Instance;
        public static Z0045.Raw.IProjectFileReferences ProjectFileReferences_Raw => Z0045.Raw.ProjectFileReferences.Instance;
        public static O0005.IProjectOperations ProjectOperations => O0005.ProjectOperations.Instance;
        public static IValues Values => S0066.Values.Instance;
        public static F0034.IWindowsExplorerOperator WindowsExplorerOperator => F0034.WindowsExplorerOperator.Instance;
    }
}