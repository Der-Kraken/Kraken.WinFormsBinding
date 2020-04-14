using System.Windows.Input;

namespace Kraken.WinFormsBinding.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        // Fields

        private SubViewModel _newestSubViewModel;

        // Constructor

        public MainViewModel()
        {
            SingletonSubViewModel = new SubViewModel();
            NewestSubViewModel = SingletonSubViewModel;
        }

        // SubViewModels

        public SubViewModel SingletonSubViewModel { get; }

        public SubViewModel NewestSubViewModel { get => _newestSubViewModel; set => SetValue(ref _newestSubViewModel, value); }

        // Commands

        public ICommand NewSubCommand => new RelayCommand(() =>
        {
            NewestSubViewModel = new SubViewModel();
        });
    }
}
