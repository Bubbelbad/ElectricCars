using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricCarMVVM.Models
{
    public class DatabaseConnection
    {
        private static DatabaseConnection _instance;
        private static readonly object _instanceLock = new object();
        List<Car> cars = new List<Car>();

        private DatabaseConnection()
        {
            cars.Add(new Car("LEAF", "Nissan", 13000, 20, 140, 10));
            cars.Add(new Car("Ioniq 5" ,"Hyundai", 15000, 30, 90, 90));
            cars.Add(new Car("EQS", "Mercedes Benz", 16000, 40, 130, 50));
            cars.Add(new Car("Model S Plaid", "Tesla", 17000, 55, 120, 30));
        }

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

        public List<CarProxy> GetProxy()
        {
            List<CarProxy> carProxies = new List<CarProxy>();
            foreach (Car car in cars)
            {
                carProxies.Add(new CarProxy(car.ModelName, car.Brand, car.Price));
            }
            return carProxies;
        }

        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public List<Car> GetCars()
        {
            return cars;
        }

        //  public Car? GetCars()
        //  {
        //       cars.Add(new Car("Leaf", 20, 140, 10));
        //       cars.Add(new Car("Leaf", 30, 90, 90));
        //       cars.Add(new Car("Leaf", 50, 130, 50));
        //       cars.Add(new Car("Leaf", 10, 120, 30));
        //       foreach (Car car in cars)
        //       {
        //           return car.ModelName;
        //       }
        //       return null;
        //  }


        //  public Car? GetCar(int id)
        //  {
        //      foreach (var car in cars)
        //      {
        //          if (car.LicensePlate == licensePlate)
        //          {
        //              return car;
        //          }
        //      }
        //      return null;
        //  }
    }
}
