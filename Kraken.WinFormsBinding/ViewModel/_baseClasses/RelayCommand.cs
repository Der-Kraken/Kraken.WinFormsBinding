using System;
using System.Windows.Input;

namespace Kraken.WinFormsBinding.ViewModel
{
    public class RelayCommand : ICommand
    {
        // Fields

        private readonly Action<object> _execute;
        private readonly Predicate<object> _canExecute;

        private bool? _lastValueOfCanExecuteChanged = null;

        // Constructors

        public RelayCommand(Action execute, Func<bool> canExecute = null)
        {
            _execute = new Action<object>(o => execute()) ?? throw new ArgumentNullException(nameof(execute));
            if (canExecute != null)
            {
                _canExecute = new Predicate<object>(o => canExecute());
            }
        }

        // Events

        public event EventHandler CanExecuteChanged;

        private void OnCanExecuteChanged(bool canExecute)
        {
            if (_lastValueOfCanExecuteChanged == canExecute) return;

            _lastValueOfCanExecuteChanged = canExecute;
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        // Methods

        public bool CanExecute(object parameter)
        {
            bool canExecuteState = _canExecute == null || _canExecute(parameter);
            OnCanExecuteChanged(canExecuteState);

            return canExecuteState;
        }

        public void Execute(object parameter)
        {
            if (!CanExecute(parameter)) return;

            _execute(parameter);

            CanExecute(parameter);
        }
    }
}
