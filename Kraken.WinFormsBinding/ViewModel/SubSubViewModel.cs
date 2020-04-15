namespace Kraken.WinFormsBinding.ViewModel
{
    public class SubSubViewModel : ViewModelBase
    {
        private string _subSubText = "Default";
        public string SubSubText { get => _subSubText; set => SetValue(ref _subSubText, value); }
    }
}
