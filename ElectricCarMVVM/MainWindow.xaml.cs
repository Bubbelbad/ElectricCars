using ElectricCarMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ElectricCarMVVM.Models;

namespace ElectricCarMVVM
{
    public partial class MainWindow : Window
    {
        MainViewModel viewModel;
        public MainWindow()
        {
            //1. Complete AddCar Views and connect it with AddCarCommand / CarBuilder
            //2. Make View for Car
            //3. Use SortingAlgorithms for MainViewModel


            InitializeComponent();
            MainViewModel mainViewModel = new MainViewModel();
            this.viewModel = mainViewModel;
            this.DataContext = mainViewModel;
        }

        private void CarList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            viewModel.ShowViewCarWindowCommand.Execute(CarList.SelectedItem);
        }

        private void FilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CarList.Items.Filter = FilterMethod;
        }

        private bool FilterMethod(object obj)
        {
            var car = (CarProxy)obj;
            return car.ModelName.Contains(FilterTextBox.Text, StringComparison.OrdinalIgnoreCase);
        }
    }
}
