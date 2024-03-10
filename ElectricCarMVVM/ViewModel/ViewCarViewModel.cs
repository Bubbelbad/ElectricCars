using ElectricCarMVVM.Commands;
using ElectricCarMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ElectricCarMVVM.ViewModel
{
    public class ViewCarViewModel
    {
        Car car = new Car();
        public ICommand ViewCarCommand { get; set; }

        public string? ModelName { get; set; }
        public string? Brand { get; set; }
        public int? Price { get; set; }
        public int? Milage { get; set; }
        public int? BatteryCapacity { get; set; }
        public int? BatteryStatus { get; set; }

        public ViewCarViewModel()
        {
            ViewCarCommand = new RelayCommand(ViewCar, CanViewCar);
        }

        private bool CanViewCar(object obj)
        {
            return true;
        }

        private void ViewCar(object obj)
        {
            DatabaseConnection db = DatabaseConnection.Instance();
            //car = db.GetCar();
        }
    }
}
