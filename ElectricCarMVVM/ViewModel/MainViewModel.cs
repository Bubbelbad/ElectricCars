using ElectricCarMVVM.Commands;
using ElectricCarMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ElectricCarMVVM.Views;

namespace ElectricCarMVVM.ViewModel
{
    public class MainViewModel
    {
        public List<CarProxy> CarProxyList { get; set; }
        public ICommand ShowWindowCommand { get; set; }

        public MainViewModel()
        {
            DatabaseConnection db = DatabaseConnection.Instance();
            CarProxyList = db.GetProxy();

            ShowWindowCommand = new RelayCommand(ShowWindow, CanShowWindow);
        }

        private bool CanShowWindow(object obj)
        {
            return true;
        }

        private void ShowWindow(object obj)
        {
            AddCar addCarWin = new AddCar();
            addCarWin.Show();
        }
    }
}
