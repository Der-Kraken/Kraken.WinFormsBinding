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

            NewSubCommand = new RelayCommand(NewSubExecute, NewSubCanExecute);
        }

        // Properties

        public SubViewModel SingletonSubViewModel { get; }

        public SubViewModel NewestSubViewModel { get => _newestSubViewModel; set => SetValue(ref _newestSubViewModel, value); }

        // Commands

        #region NewSubCommand

        public ICommand NewSubCommand { get; private set; }

        private bool NewSubCanExecute()
        {
            return true;
        }

        private void NewSubExecute()
        {
            NewestSubViewModel = new SubViewModel();
        }

        #endregion
    }
}
