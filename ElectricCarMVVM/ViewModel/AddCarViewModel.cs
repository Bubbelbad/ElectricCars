using ElectricCarMVVM.Commands;
using ElectricCarMVVM.Models;
using ElectricCarMVVM.Views;
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
        public int Id { get; set; }
        public string ModelName { get; set; }
        public string Brand { get; set; }
        public int Price { get; set; }
        public int Milage { get; set; }
        public int BatteryCapacity { get; set; }
        public int BatteryStatus { get; set; }

        public ICommand AddCarCommand { get; set; }


        public AddCarViewModel() 
        {
            AddCarCommand = new RelayCommand(AddCar, CanAddCar);
        }


        private bool CanAddCar(object? obj)
        {
            return true;
        }
      
        private void AddCar(object? obj)
        {
            if (ModelName != null && Brand != null && Price != 0)
            {
                MessageBox.Show("Car succesfully added to collection");
            }
            else
            {
                MessageBox.Show("You need to minimum fill in things model name, brand and price...");
                return;
            }
      
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
