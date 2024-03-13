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
        Car car = null; 
        public ICommand ViewCarCommand { get; set; }

        public int Id { get; set; }
        public string ModelName { get; set; }
        public string Brand { get; set; }
        public int Price { get; set; }
        public int Milage { get; set; }
        public int BatteryCapacity { get; set; }
        public int BatteryStatus { get; set; }

        public ViewCarViewModel(string modelName)
        {
            DatabaseConnection db = DatabaseConnection.Instance();
            car = db.GetCar(modelName);

            this.Id = car.Id;
            this.ModelName = car.ModelName;
            this.Brand = car.Brand;
            this.Price = car.Price;
            this.Milage = car.Milage;
            this.BatteryCapacity = car.BatteryCapacity;
            this.BatteryStatus = car.BatteryStatus;
        }
    }
}
