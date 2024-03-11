using ElectricCarMVVM.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ElectricCarMVVM.Commands
{
    public class ShowAddCarWindowCommand : RelayCommand
    {
        public ShowAddCarWindowCommand() : base(null, null)
        {
            this._CanExecute = CanExecute;
            _Execute = Execute;
        }

        private bool CanExecute(object? obj)
        {
            return true;
        }

        private void Execute(object? parameter)
        {
            var mainWindow = parameter as Window;
            AddCar addCarWin = new AddCar();
            addCarWin.Owner = mainWindow;
            addCarWin.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            addCarWin.Show();
        }
    }
}
