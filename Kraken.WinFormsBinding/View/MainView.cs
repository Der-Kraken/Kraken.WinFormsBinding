using Kraken.WinFormsBinding.Tools;
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
            var bindingSource = new BindingSource(this, nameof(ViewModel));

            // Left Side - Singleton SubViewModel
            {
                SingletonSubViewModelNumberTxt.DataBindings.Add("Text", bindingSource, "SingletonSubViewModel.Number", false, DataSourceUpdateMode.OnPropertyChanged);
                {
                    string path = TypeSafeMagicStrings.GetPropertyPath<MainViewModel>(vm => vm.SingletonSubViewModel.SubSubViewModel.SubSubText);
                    var binding = SingletonSubSubViewModelTextTxt.DataBindings.Add("Text", bindingSource, path, false, DataSourceUpdateMode.OnPropertyChanged);
                    ObserveBindingPath(bindingSource, path);
                }

                subViewSingleton.DataBindings.Add("ViewModel", bindingSource, "SingletonSubViewModel");
                subViewSingletonClone.DataBindings.Add("ViewModel", bindingSource, "SingletonSubViewModel");
            }

            // Right Side - Newest SubViewModel
            {
                // The binding below only work because dataSource is from type BindingSource.
                NewestSubViewModelNumberTxt.DataBindings.Add("Text", bindingSource, "NewestSubViewModel.Number", false, DataSourceUpdateMode.OnPropertyChanged);
                // !!! The problematic binding below !!!
                {
                    string path = "NewestSubViewModel.SubSubViewModel.SubSubText";
                    var binding = NewestSubSubViewModelTextTxt.DataBindings.Add("Text", bindingSource, path, false, DataSourceUpdateMode.OnPropertyChanged);
                    ObserveBindingPath(bindingSource, path);
                }

                // This bindings are working well
                subViewNewest.DataBindings.Add("ViewModel", bindingSource, "NewestSubViewModel");
                subViewNewestClone.DataBindings.Add("ViewModel", bindingSource, "NewestSubViewModel");
            }
        }

        // Other

        private void NewSubViewModelBtn_Click(object sender, System.EventArgs e)
        {
            // Command is hard executed because to focus the project to the main problem.
            ViewModel.NewSubCommand.Execute(null);
        }

        public void ObserveBindingPath(BindingSource bindingSource, string propPath)
        {
            var resolver = new PropertyChangedObserver(ViewModel, propPath);
            resolver.StartObserving();
            resolver.ObservablePropertyChanged += (s, e) =>
            {
                bindingSource.ResetBindings(false);
            };
        }
    }
}