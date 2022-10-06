using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using SampleWpfWithPrism.Common;
using SampleWpfWithPrism.Interfaces;
using SampleWpfWithPrism.Module1.Views;
using SampleWpfWithPrism.SampleService;

namespace SampleWpfWithPrism.Module1
{
    public class Module1Module : IModule
    {
        public Module1Module(IRegionManager regionManager, IApplicationCommands applicationCommands)
        {
            _regionManager = regionManager;
            _applicationCommands = applicationCommands;
        }

        public IRegionManager _regionManager { get; }
        public IApplicationCommands _applicationCommands { get; }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _applicationCommands.navigationCommand.Execute("ViewA");
        }

        
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA>();
            containerRegistry.Register<IMessageService, MessageService>();
        }
    }
}