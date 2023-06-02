using System;
using System.Threading.Tasks;


namespace R5T.S0066
{
    class Program
    {
        static async Task Main()
        {
            //await ProjectGenerationScripts.Instance.Create_LibraryProject();
            //await ProjectGenerationScripts.Instance.Create_ConsoleProject();
            await ProjectGenerationScripts.Instance.Create_WebServerForBlazorClientProject();

            //await ProjectScripts.Instance.AddProjectReferences();
        }
    }
}