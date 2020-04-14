using Kraken.WinFormsBinding.ViewModel;
using System.ComponentModel;
using System.Windows.Forms;

namespace Kraken.WinFormsBinding.View
{
    public partial class SubView : UserControl
    {
        public SubView()
        {
            InitializeComponent();
        }

        private SubViewModel _viewModel;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public SubViewModel ViewModel
        {
            get => _viewModel;
            set
            {
                if (object.Equals(_viewModel, value)) return;

                if (_viewModel != null)
                {
                    Unbind();
                }

                _viewModel = value;

                SetupBinding();
            }
        }

        // Methods - Binding Configuration

        private void SetupBinding()
        {
            GenerationLbl.DataBindings.Add(nameof(GenerationLbl.Text), ViewModel, nameof(ViewModel.Generation), false, DataSourceUpdateMode.OnPropertyChanged);
            NumberTxt.DataBindings.Add(nameof(NumberTxt.Text), ViewModel, nameof(ViewModel.Number), false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void Unbind()
        {
            GenerationLbl.DataBindings.Clear();
            NumberTxt.DataBindings.Clear();
        }
    }
}
