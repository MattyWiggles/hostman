using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace HostmanUI.Support
{

    public class Command : ICommand
    {
        protected Action<object> ExecuteAction;
        private readonly Predicate<object> _canExecute;

        public string Name { get; set; }

        public Key Key { get; set; }

        public ModifierKeys ModifierKeys { get; set; }

        public Command(Action<object> executeAction)
            : this(executeAction, null)
        {
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                if (_canExecute == null)
                {
                    return;
                }
                CommandManager.RequerySuggested += value;
            }

            remove
            {
                if (_canExecute == null)
                {
                    return;
                }
                CommandManager.RequerySuggested -= value;
            }
        }

        protected Command()
        {
        }

        public Command(Action<object> executeAction, Predicate<object> canExecute)
        {
            if (executeAction == null)
            {
                throw new ArgumentNullException("executeAction");
            }
            ExecuteAction = executeAction;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            ExecuteAction(parameter);
        }

        public Command Clone(Action<object> execute, Predicate<object> canExecute)
        {
            return new Command(execute, canExecute) { Key = Key, ModifierKeys = ModifierKeys, Name = Name };
        }
    }
}
