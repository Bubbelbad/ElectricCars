using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricCarMVVM.Models
{
    public class CarProxy
    {
        Car car = null;
        DatabaseConnection instance = DatabaseConnection.Instance();
        public string ModelName { get; set; }
        public string Brand { get; set; }
        public int Price { get; set; }

        public CarProxy(string modelName, string brand, int price)
        {
            this.instance = instance;
            this.ModelName = modelName;
            this.Brand = brand;
            this.Price = price;
        }


        //  public string ModelName {
        //      get {
        //          Load();
        //          return car.ModelName;
        //      }
        //      set {
        //          Load();
        //          car.ModelName = value;
        //      }
        //  }

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

        //  public int BatteryCapacity {
        //      get {
        //          Load();
        //          return car.Milage;
        //      }
        //      set {
        //          Load();
        //          car.Milage = value;
        //      }
        //  }

        public int BatteryStatus
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


        public void Load()
        {
            DatabaseConnection instance = DatabaseConnection.Instance();
            if (car == null)
            {
                // car = instance.GetProxy();
                // return proxyList;
            }

        }
    }
}
