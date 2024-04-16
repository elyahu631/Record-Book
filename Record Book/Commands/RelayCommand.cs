using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Record_Book.Commands
{
    public class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private Action<object> _Excute {  get; set; }
        private Predicate<object> _CanExcute { get; set; }

        public RelayCommand(Action<object> excuteMethod, Predicate<object> CanExcuteMethod)
        {
            _Excute = excuteMethod;
            _CanExcute = CanExcuteMethod;
        }
        public bool CanExecute(object? parameter)
        {
            return _CanExcute(parameter);
        }

        public void Execute(object? parameter)
        {
            _Excute(parameter);
        }
    }
}
