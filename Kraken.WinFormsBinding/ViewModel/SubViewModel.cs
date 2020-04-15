namespace Kraken.WinFormsBinding.ViewModel
{
    public class SubViewModel : ViewModelBase
    {
        private static int Counter = 1;

        public SubViewModel()
        {
            Generation = Counter++;
            Number = Generation;

            SubSubViewModel = new SubSubViewModel();
        }

        // Properties - SubViewModels

        private SubSubViewModel _subSubViewModel;
        public SubSubViewModel SubSubViewModel { get => _subSubViewModel; private set => SetValue(ref _subSubViewModel, value); }

        // Properties

        public int Generation { get; }

        private int _number;
        public int Number { get => _number; set => SetValue(ref _number, value); }
    }
}
