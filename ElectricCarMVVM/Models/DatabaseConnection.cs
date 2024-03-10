using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricCarMVVM.Models
{
    public class DatabaseConnection
    {
        /// <summary>
        /// Fictive singleton database until there is a real database for this project. 
        /// 
        /// 
        /// </summary>
        /// 


        private static DatabaseConnection _instance;
        private static readonly object _instanceLock = new object();
        private static List<Car> cars = new List<Car>() { new Car { Id = 0, ModelName = "LEAF", Brand = "Nissan", Price = 13000, Milage = 20, BatteryCapacity = 140, BatteryStatus = 10 },
                                                          new Car { Id = 1, ModelName = "Ioniq 5", Brand = "Hyundai", Price = 14500, Milage = 20, BatteryCapacity = 140, BatteryStatus = 10 },
                                                          new Car { Id = 2, ModelName = "EQS", Brand = "Mercedes Benz", Price = 23000, Milage = 20, BatteryCapacity = 140, BatteryStatus = 10 },
                                                          new Car { Id = 3, ModelName = "Model S Plaid", Brand = "Tesl", Price = 10986, Milage = 20, BatteryCapacity = 140, BatteryStatus = 10 } };
                                                          
    
        private static ObservableCollection<CarProxy> carProxies = new ObservableCollection<CarProxy>() {  };

        private DatabaseConnection()
        {

        }

        //Instance() will be used to acces the database from everywhere in theprogram
        public static DatabaseConnection Instance()
        {
            //Locking the instance so that it can't be called simultaniously by two instances
            if (_instance == null)
            {
                lock (_instanceLock)
                {
                    if (_instance == null)
                    {
                        _instance = new DatabaseConnection();
                    }
                }
                _instance = new DatabaseConnection();
            }
            return _instance;
        }

        public ObservableCollection<CarProxy> GetProxy()
        {
            foreach (Car car in  cars)
            {
                carProxies.Add(new CarProxy(car.ModelName, car.Brand, car.Price));
            }
            return carProxies;
        }

       // public List<CarProxy> GetProxy()
       // {
       //     List<CarProxy> carProxies = new List<CarProxy>();
       //     foreach (Car car in cars)
       //     {
       //         carProxies.Add(new CarProxy(car.ModelName, car.Brand, car.Price));
       //     }
       //     return carProxies;
       // }

        public void AddCar(Car car, CarProxy proxy)
        {
            cars.Add(car);
            carProxies.Add(proxy);
        }


        public Car? GetCar(CarProxy proxy)
        {
            foreach (Car car in cars)
            {
                if (proxy.ModelName == car.ModelName)
                {
                    return car;
                }
            }
            return null;
        }
    }
}
