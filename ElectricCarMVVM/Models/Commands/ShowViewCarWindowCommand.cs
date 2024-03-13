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
        private void Execute(object? obj) //Obj might have to be mainWindow here. See if I can change function to binding in MainWindow.View instead...
        {                                 //But what do I do with the CarProxy then? Can i have two parameters, send both perhaps?
            var mainWindow = obj as Window;
            ViewCar viewCarWin = new ViewCar((CarProxy)obj);  
            viewCarWin.Owner = mainWindow;
            viewCarWin.WindowStartupLocation = WindowStartupLocation.CenterOwner; //This code is not working! obj is empty I think
            viewCarWin.Show();
        }
    }
}
