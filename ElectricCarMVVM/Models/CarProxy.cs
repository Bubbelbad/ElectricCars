using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricCarMVVM.Models
{
    public class CarProxy
    {

        //I don't understand the Load() function here. Should I return a Car or just a proxy? 
        //
        //

        CarProxy car = null;
        DatabaseConnection instance = DatabaseConnection.Instance();
        public string ModelName { get; set; }
        public string Brand { get; set; }
        public int Price { get; set; }

        public CarProxy(string modelName, string brand, int price)
        {
            this.ModelName = modelName;
            this.Brand = brand;
            this.Price = price;
        }


        public int Milage
        {
            get
            {
                Load();
                return car.Milage;
            }
            set
            {
                Load();
                car.Milage = value;
            }
        }

          public int BatteryCapacity {
              get {
                  Load();
                  return car.BatteryCapacity;
              }
              set {
                  Load();
                  car.BatteryCapacity = value;
              }
          }

        public int BatteryStatus
        {
            get
            {
                Load();
                return car.BatteryStatus;
            }
            set
            {
                Load();
                car.BatteryStatus = value;
            }
        }


        public void Load()
        {
            DatabaseConnection instance = DatabaseConnection.Instance();
            if (car == null)
            {
              // car = instance.GetCar();
            }
        }
    }
}
