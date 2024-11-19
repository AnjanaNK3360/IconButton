using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace IconButtonTestApp
{
    public class CustomCommand : ICommand
    {
        private readonly Action<object> _execute;

        public CustomCommand(Action<object> execute)
        {
            _execute = execute;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;
       

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
