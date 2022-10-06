using Prism.Commands;

namespace SampleWpfWithPrism.Common
{
    public interface IApplicationCommands
    {
        CompositeCommand navigationCommand { get; }
    }
}
