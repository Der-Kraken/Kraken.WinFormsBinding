using Kraken.WinFormsBinding.ViewModel;
using System.ComponentModel;
using System.Windows.Forms;

namespace Kraken.WinFormsBinding.View
{
    public partial class SubSubView : UserControl
    {
        private BindingSource _bindingSource;

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
            this.Enabled = ViewModel != null;
            if (ViewModel == null)
            {
                return;
            }

            _bindingSource = new BindingSource(this, "ViewModel");

            SubSubTxt.DataBindings.Add(nameof(SubSubTxt.Text), _bindingSource, nameof(ViewModel.SubSubText), false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void Unbind()
        {
            _bindingSource?.Dispose();
            _bindingSource = null;

            SubSubTxt.DataBindings.Clear();
        }
    }
}
