using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using SampleWpfWithPrism.Common;

namespace SampleWpfWithPrism.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        private DelegateCommand<string> _navigationCommand;
        public IRegionManager _regionmanager { get; }
        public IApplicationCommands _applicationCommands;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public DelegateCommand<string> NavigationCommand =>
          _navigationCommand ?? (_navigationCommand = new DelegateCommand<string>(ExecuteNavigationCommand, CanExecuteNavigationCommand));

        void ExecuteNavigationCommand(string parameter)
        {
            _regionmanager.RequestNavigate(RegionNames.ContentRegion, parameter);
        }

        bool CanExecuteNavigationCommand(string parameter)
        {
            return true;
        }

        public MainWindowViewModel(IRegionManager regionmanager, IApplicationCommands applicationCommands)
        {
            _regionmanager = regionmanager;
            _applicationCommands = applicationCommands;
            _applicationCommands.navigationCommand.RegisterCommand(NavigationCommand);
        }
    }
}
