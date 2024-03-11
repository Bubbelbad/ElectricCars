using ElectricCarMVVM.Models;
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
using System.Windows.Shapes;

namespace ElectricCarMVVM.Views
{
    /// <summary>
    /// Interaction logic for ViewCar.xaml
    /// </summary>
    public partial class ViewCar : Window
    {
        public ViewCar(CarProxy proxy)
        {
            InitializeComponent();
            ViewCarViewModel viewModel = new ViewCarViewModel(proxy.ModelName);
            this.DataContext = viewModel;
        }
    }
}
