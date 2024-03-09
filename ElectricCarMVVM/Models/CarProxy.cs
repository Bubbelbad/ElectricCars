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
        public int BatteryCapacity { get; set; }

        public CarProxy(string modelName, int batteryCapacity)
        {
            this.instance = instance;
            this.ModelName = modelName;
            this.BatteryCapacity = batteryCapacity;
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
