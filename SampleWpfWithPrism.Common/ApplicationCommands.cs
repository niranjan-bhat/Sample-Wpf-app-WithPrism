using Prism.Commands;

namespace SampleWpfWithPrism.Common
{
    public class ApplicationCommands : IApplicationCommands
    {
        public CompositeCommand navigationCommand { get; } = new CompositeCommand();
    }
}
