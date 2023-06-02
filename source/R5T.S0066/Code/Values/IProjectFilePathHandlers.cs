using System;
using System.Threading.Tasks;

using R5T.T0131;
using R5T.T0172;


namespace R5T.S0066
{
    [ValuesMarker]
    public partial interface IProjectFilePathHandlers : IValuesMarker
    {
        public Task Default(IProjectFilePath projectFilePath)
        {
            Instances.NotepadPlusPlusOperator.Open(
                projectFilePath.Value);

            return Task.CompletedTask;
        }
    }
}
