﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ElectricCarMVVM.Commands
{
    public class RelayCommand : ICommand
    {
        //RelayCommand is a class that implements ICommand interface

        public event EventHandler? CanExecuteChanged;
        public Action<Object> _Execute { get; set; }
        public Predicate<Object> _CanExecute { get; set; }

        public RelayCommand(Action<object> executeMethod, Predicate<object> canExecuteMethod)
        {
            _Execute = executeMethod;
            _CanExecute = canExecuteMethod;
        }

        public bool CanExecute(object? parameter)
        {
            return _CanExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            _Execute(parameter);
        }
    }
}
