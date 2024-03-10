using ElectricCarMVVM.Commands;
using ElectricCarMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ElectricCarMVVM.ViewModel
{
    public class AddCarViewModel
    {
        public ICommand AddCarCommand { get; set; }

        public int Id { get; set; }
        public string ModelName { get; set; }
        public string Brand { get; set; }
        public int Price { get; set; }
        public int Milage { get; set; }
        public int BatteryCapacity { get; set; }
        public int BatteryStatus { get; set; }


        public AddCarViewModel()
        {
            AddCarCommand = new RelayCommand(AddCar, CanAddUser);
        }

        private bool CanAddUser(object obj)
        {
            return true;
        }

        private void AddCar(object obj)
        {
            DatabaseConnection db = DatabaseConnection.Instance();
            CarBuilder carBuilder = new CarBuilder();

            Car car = carBuilder.SetModelName(ModelName)
                                .SetBrand(Brand)
                                .SetPrice(Price)
                                .SetMilage(Milage)
                                .SetBatteryCapacity(BatteryCapacity)
                                .Build();

            CarProxy proxy = new CarProxy(car.ModelName, car.Brand, car.Price);
            db.AddCar(car, proxy);
        }
    }
}
