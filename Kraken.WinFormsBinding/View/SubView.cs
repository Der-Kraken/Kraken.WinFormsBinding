using Kraken.WinFormsBinding.ViewModel;
using System.ComponentModel;
using System.Windows.Forms;

namespace Kraken.WinFormsBinding.View
{
    public partial class SubView : UserControl
    {
        BindingSource _bindingSource;

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
            _bindingSource = new BindingSource(this, nameof(ViewModel));

            GenerationLbl.DataBindings.Add(nameof(GenerationLbl.Text), _bindingSource, nameof(ViewModel.Generation), false, DataSourceUpdateMode.OnPropertyChanged);
            NumberTxt.DataBindings.Add(nameof(NumberTxt.Text), _bindingSource, nameof(ViewModel.Number), false, DataSourceUpdateMode.OnPropertyChanged);

            subSubView1.DataBindings.Add(nameof(subSubView1.ViewModel), _bindingSource, "SubSubViewModel");
        }

        private void Unbind()
        {
            _bindingSource.Dispose();
            _bindingSource = null;

            GenerationLbl.DataBindings.Clear();
            NumberTxt.DataBindings.Clear();

            subSubView1.DataBindings.Clear();
        }
    }
}
