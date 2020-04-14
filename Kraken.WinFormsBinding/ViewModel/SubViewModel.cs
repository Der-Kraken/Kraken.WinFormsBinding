namespace Kraken.WinFormsBinding.ViewModel
{
    public class SubViewModel : ViewModelBase
    {
        private static int Counter = 1;

        public SubViewModel()
        {
            Generation = Counter++;
            Number = Generation;
        }

        public int Generation { get; }

        private int _number;
        public int Number { get => _number; set => SetValue(ref _number, value); }
    }
}
