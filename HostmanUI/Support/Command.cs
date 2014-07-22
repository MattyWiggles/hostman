
namespace HostmanUI.Support
{

    using System;
    using System.Windows.Input;

    namespace HostmanUI.Support
    {

        public class RelayCommand : ICommand
        {
            Action<object> _execute;
            Func<bool> _canExecute;

            Action _executeParamLess;

            public RelayCommand(Action<object> executeAction)
                : this(executeAction, null)
            {
            }

            public RelayCommand(Action executeAction)
                :this(executeAction, null)
            {
            }

            public RelayCommand(Action execute, Func<bool> canExecute)
            {
                if (execute == null)
                    throw new ArgumentNullException("execute");
                _executeParamLess = execute;
                _canExecute = canExecute;
            }

            public RelayCommand(Action<object> execute, Func<bool> canExecute)
            {
                if (execute == null)
                    throw new ArgumentNullException("execute");
                _execute = execute;
                _canExecute = canExecute;
            }

            public bool CanExecute(object param)
            {
                return _canExecute == null ? true : _canExecute();
            }

            public void Execute(object param)
            {
                if (_executeParamLess != null)
                    _executeParamLess();
                else
                    _execute(param);
            }

            public void Refresh()
            {
                RaiseCanExecuteChanged();
            }

            public event EventHandler CanExecuteChanged;

            public void RaiseCanExecuteChanged()
            {
                var handler = CanExecuteChanged;
                if (handler != null)
                {
                    handler(this, EventArgs.Empty);
                }
            }
        }
    }

}
