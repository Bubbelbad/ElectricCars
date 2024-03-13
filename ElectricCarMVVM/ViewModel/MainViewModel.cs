using ElectricCarMVVM.Commands;
using ElectricCarMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ElectricCarMVVM.Views;
using System.Windows;
using ElectricCarMVVM.Models.SortingAlgorithms;
using System.Collections.ObjectModel;
using ElectricCarMVVM.Interfaces;
using ElectricCarMVVM.Models.Commands;

namespace ElectricCarMVVM.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<CarProxy> CarProxyList { get; set; }

        public ICommand ShowAddCarWindowCommand { get; set; }
        public ICommand ShowViewCarWindowCommand { get; set; }
        public ICommand SortByPriceCommand { get; set; }
        public ICommand SortByBrandCommand { get; set; }
        public ICommand SortByModelNameCommand { get; set; }
        public ICommand DeleteCarCommand { get; set; }

        CarProxy selectedProxy;
        
        public MainViewModel()
        {
            DatabaseConnection db = DatabaseConnection.Instance();
            CarProxyList = db.GetProxy();
            ShowAddCarWindowCommand = new ShowAddCarWindowCommand();
            ShowViewCarWindowCommand = new ShowViewCarWindowCommand();
            SortByPriceCommand = new SortByPriceCommand(CarProxyList);
            SortByBrandCommand = new SortByBrandCommand(CarProxyList);
            SortByModelNameCommand = new QuickSortCommand(CarProxyList);
            DeleteCarCommand = new DeleteCarCommand(selectedProxy);
        }
    }
}
