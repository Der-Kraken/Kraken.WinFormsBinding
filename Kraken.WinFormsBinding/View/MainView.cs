using Kraken.WinFormsBinding.ViewModel;
using System.Windows.Forms;

namespace Kraken.WinFormsBinding.View
{
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
            Load += (s, e) =>
            {
                ViewModel = new MainViewModel();
                SetupBinding();
            };
        }

        public MainViewModel ViewModel { get; private set; }

        // Methods - Binding Configuration

        private void SetupBinding()
        {
            // Left Side - Singleton SubViewModel
            {
                SingletonSubViewModelTxt.DataBindings.Add("Text", ViewModel, "SingletonSubViewModel.Number", false, DataSourceUpdateMode.OnPropertyChanged);

                subViewSingleton.DataBindings.Add("ViewModel", ViewModel, "SingletonSubViewModel");
                subViewSingletonClone.DataBindings.Add("ViewModel", ViewModel, "SingletonSubViewModel");
            }

            // Right Side - Newest SubViewModel
            {
                // !!! The problematic binding below !!!
                NewestSubViewModelTxt.DataBindings.Add("Text", ViewModel, "NewestSubViewModel.Number", false, DataSourceUpdateMode.OnPropertyChanged);

                // This bindings are working well
                subViewNewest.DataBindings.Add("ViewModel", ViewModel, "NewestSubViewModel");
                subViewNewestClone.DataBindings.Add("ViewModel", ViewModel, "NewestSubViewModel");
            }
        }

        // Other

        private void NewSubViewModelBtn_Click(object sender, System.EventArgs e)
        {
            // Command is hard executed because to focus the project to the main problem.
            ViewModel.NewSubCommand.Execute(null);
        }
    }
}