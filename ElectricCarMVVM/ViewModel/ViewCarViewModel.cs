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
        Car car;
        //CarProxy proxy;
        public ICommand ViewCarCommand { get; set; }

        public int Id { get; set; }
        public string ModelName { get; set; }
        public string Brand { get; set; }
        public int Price { get; set; }
        public int Milage { get; set; }
        public int BatteryCapacity { get; set; }
        public int BatteryStatus { get; set; }

        public ViewCarViewModel(string modelName) //Do I even use the Proxy ??? I don't get this..
        {
            DatabaseConnection db = DatabaseConnection.Instance();
            ViewCarCommand = new RelayCommand(ViewCar, CanViewCar);
            car = db.GetCar(modelName);
            //this.proxy = proxy;

            this.Id = car.Id;
            this.ModelName = car.ModelName;
            this.Brand = car.Brand;
            this.Price = car.Price;
            this.Milage = car.Milage;
            this.BatteryCapacity = car.BatteryCapacity;
            this.BatteryStatus = car.BatteryStatus;
        }

        private bool CanViewCar(object obj)
        {
            return true;
        }

        private void ViewCar(object obj)
        {
            DatabaseConnection db = DatabaseConnection.Instance();
            //car = proxy.Load(ModelName);
        }
    }
}
