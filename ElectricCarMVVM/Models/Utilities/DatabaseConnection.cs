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
        //Fictive singleton database for this project for easy access.

        private static DatabaseConnection _instance;
        private static readonly object _instanceLock = new object();
        private static List<Car> cars = new List<Car>() { new Car { Id = 0, ModelName = "LEAF", Brand = "Nissan", Price = 13000, Milage = 20, BatteryCapacity = 140, BatteryStatus = 10 },
                                                          new Car { Id = 1, ModelName = "Ioniq 5", Brand = "Hyundai", Price = 14500, Milage = 20, BatteryCapacity = 140, BatteryStatus = 10 },
                                                          new Car { Id = 2, ModelName = "EQS", Brand = "Mercedes Benz", Price = 23000, Milage = 20, BatteryCapacity = 140, BatteryStatus = 10 },
                                                          new Car { Id = 3, ModelName = "Model S Plaid", Brand = "Tesla", Price = 10986, Milage = 20, BatteryCapacity = 140, BatteryStatus = 10 },
                                                          new Car { Id = 4, ModelName = "Model 3", Brand = "Tesla", Price = 45000, Milage = 250, BatteryCapacity = 60, BatteryStatus = 90 },
                                                          new Car { Id = 4, ModelName = "Bolt EV", Brand = "Chevrolet", Price = 36000, Milage = 259, BatteryCapacity = 66, BatteryStatus = 80 },
                                                          new Car { Id = 4, ModelName = "Mustang Mach-E", Brand = "Ford", Price = 42895, Milage = 230, BatteryCapacity = 68, BatteryStatus = 85 },
                                                          new Car { Id = 4, ModelName = "ID.4", Brand = "Volkswagen", Price = 39995, Milage = 250, BatteryCapacity = 82, BatteryStatus = 92 },
                                                          new Car { Id = 4, ModelName = "i4", Brand = "BMW", Price = 55400, Milage = 300, BatteryCapacity = 83, BatteryStatus = 95 },
                                                          new Car { Id = 4, ModelName = "Air", Brand = "Lucid", Price = 77400, Milage = 406, BatteryCapacity = 113, BatteryStatus = 98 },
                                                          new Car { Id = 3, ModelName = "Taycan", Brand = "Porsche", Price = 79900, Milage = 225, BatteryCapacity = 79, BatteryStatus = 90 },
                                                          new Car { Id = 3, ModelName = "R1T", Brand = "Rivian", Price = 67500, Milage = 314, BatteryCapacity = 135, BatteryStatus = 97 } };
         
        //I chose to save my CarProxys in a Observable Collection so that it refreshes instantly whenever I add a new car/proxy.
        private static ObservableCollection<CarProxy> carProxies = new ObservableCollection<CarProxy>() {  };

        private DatabaseConnection() { }

        //Instance() will be used to acces the database from everywhere in theprogram
        public static DatabaseConnection Instance()
        {
            //Locking the instance so that it can't be initiated simultaniously by two instances
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


        public void AddCar(Car car, CarProxy proxy)
        {
            cars.Add(car);
            carProxies.Add(proxy);
        }


        public Car? GetCar(string modelName)
        {
            foreach (Car car in cars)
            {
                if (modelName == car.ModelName)
                {
                    return car;
                }
            }
            return null;
        }

        internal void DeleteCar(CarProxy proxy)
        {
            foreach (Car car in cars)
            {
                if (proxy.ModelName == car.ModelName)
                {
                    cars.Remove(car);
                    carProxies.Remove(proxy);
                    return;
                }
            }
        }
    }
}
