using Kraken.WinFormsBinding.ViewModel;
using System.ComponentModel;
using System.Windows.Forms;

namespace Kraken.WinFormsBinding.View
{
    public partial class SubSubView : UserControl
    {
        public SubSubView()
        {
            InitializeComponent();
        }

        private SubSubViewModel _viewModel;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public SubSubViewModel ViewModel
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
            SubSubTxt.DataBindings.Add(nameof(SubSubTxt.Text), ViewModel, nameof(ViewModel.SubSubText), false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void Unbind()
        {
            SubSubTxt.DataBindings.Clear();
        }
    }
}
