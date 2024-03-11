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

        public MainViewModel()
        {
            DatabaseConnection db = DatabaseConnection.Instance();
            CarProxyList = db.GetProxy();
            ShowAddCarWindowCommand = new RelayCommand(ShowAddCarWindow, CanExecute);
            ShowViewCarWindowCommand = new RelayCommand(ShowViewCarWindow, CanExecute);
            SortByPriceCommand = new RelayCommand(SortByPrice, CanExecute);

        }

        private bool CanExecute(object obj)
        {
            return true;
        }

        private void ShowAddCarWindow(object obj)
        {
            var mainWindow = obj as Window;
            AddCar addCarWin = new AddCar();
            addCarWin.Owner = mainWindow;
            addCarWin.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            addCarWin.Show();
        }

        private void ShowViewCarWindow(object obj)
        {
            var mainWindow = obj as Window;
            ViewCar viewCarWin = new ViewCar((CarProxy)obj);
            viewCarWin.Owner = mainWindow;
            viewCarWin.WindowStartupLocation= WindowStartupLocation.CenterOwner;
            viewCarWin.Show();
        }

        private void SortByPrice(object obj)
        {
            Converter converter = new Converter();
            InsertionSort sorter = new InsertionSort();
            int[] array = converter.Convert();
            sorter.Sort(array);
            //sorter.
            MessageBox.Show("We got here");
        }

        private void ImportCommands()
        {
            //Maybe I can import all commands through here? 
            //This class doesn't feel like it's Closed to Modification...
        }
    }
}
