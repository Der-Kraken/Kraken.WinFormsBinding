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
            subViewSingleton.DataBindings.Add(nameof(subViewSingleton.ViewModel), ViewModel, nameof(ViewModel.SingletonSubViewModel));
            subViewNewest.DataBindings.Add(nameof(subViewNewest.ViewModel), ViewModel, nameof(ViewModel.NewestSubViewModel));

            subViewSingletonClone.DataBindings.Add(nameof(subViewSingletonClone.ViewModel), ViewModel, nameof(ViewModel.SingletonSubViewModel));
            subViewNewestClone.DataBindings.Add(nameof(subViewNewestClone.ViewModel), ViewModel, nameof(ViewModel.NewestSubViewModel));

            SingletonSubViewModelTxt.DataBindings.Add(nameof(SingletonSubViewModelTxt.Text), ViewModel, "SingletonSubViewModel.Number", false, DataSourceUpdateMode.OnPropertyChanged);
            // !!! The problematic binding below !!!
            NewestSubViewModel.DataBindings.Add(nameof(NewestSubViewModel.Text), ViewModel, "NewestSubViewModel.Number", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        // Other

        private void NewSubViewModelBtn_Click(object sender, System.EventArgs e)
        {
            // Command is hard executed because to focus the project to the main problem.
            ViewModel.NewSubCommand.Execute(null);
        }
    }
}