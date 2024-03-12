using ElectricCarMVVM.Models;
using ElectricCarMVVM.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ElectricCarMVVM.Commands
{
    public class ShowViewCarWindowCommand : RelayCommand
    {
        public ShowViewCarWindowCommand() : base(null, null)
        {
            this._Execute = Execute;
                 _CanExecute = CanExecute;
        }

        private bool CanExecute(object? obj)
        {
            return true;
        }

        //Opens new viewCar
        private void Execute(object? obj)
        {
            var mainWindow = obj as Window;
            ViewCar viewCarWin = new ViewCar((CarProxy)obj);
            viewCarWin.Owner = mainWindow;
            viewCarWin.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            viewCarWin.Show();
        }
    }
}
