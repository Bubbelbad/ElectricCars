using System;
using System.Collections.Generic;
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
        List<Car> cars = new List<Car>();

        private DatabaseConnection()
        {
            cars.Add(new Car(0, "LEAF", "Nissan", 13000, 20, 140, 10));
            cars.Add(new Car(1, "Ioniq 5" ,"Hyundai", 15000, 30, 90, 90));
            cars.Add(new Car(2, "EQS", "Mercedes Benz", 16000, 40, 130, 50));
            cars.Add(new Car(3, "Model S Plaid", "Tesla", 17000, 55, 120, 30));
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

        public Car GetCar(int id)
        {
            Car car1 = null;
            foreach (Car car in cars)
            {
                if (id == car.Id)
                {
                    car1 = car;
                }
            }
            return car1;
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
