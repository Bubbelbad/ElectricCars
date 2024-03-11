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

namespace ElectricCarMVVM.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<CarProxy> CarProxyList { get; set; }

        //Will this be useful somehow?:
        List<string> choiceStrings = new List<string>();
        Dictionary<string, ICommand> choiceDictionary = new Dictionary<string, ICommand>();


        public ICommand ShowAddCarWindowCommand { get; set; }
        public ICommand ShowViewCarWindowCommand { get; set; }
        public ICommand SortByPriceCommand { get; set; }
        public ICommand SortByBrandCommand { get; set; }
        

        //Kontruktorn borde ha en dictionary med alla commands ?
        public MainViewModel()
        {
            DatabaseConnection db = DatabaseConnection.Instance();
            CarProxyList = db.GetProxy();
            //ShowAddCarWindowCommand = new RelayCommand(ShowAddCarWindow, CanExecute);
            ShowAddCarWindowCommand = new ShowAddCarWindowCommand();
            ShowViewCarWindowCommand = new ShowViewCarWindowCommand();
            SortByPriceCommand = new SortByPriceCommand(CarProxyList);
            SortByBrandCommand = new SortByBrandCommand(CarProxyList);
        }
    }
}
