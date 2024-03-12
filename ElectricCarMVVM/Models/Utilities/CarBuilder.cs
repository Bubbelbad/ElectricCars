using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricCarMVVM.Models
{
    public class CarBuilder
    {
        private int Id { get; set; } = 0;
        private string ModelName { get; set; } = "";
        private string Brand { get; set; } = "";
        private int Price { get; set; } = 0;
        private int Milage { get; set; } = 0;
        private int BatteryCapacity { get; set; } = 0;
        private int BatteryStatus { get; set; } = 0;

        public CarBuilder(){ }

        public CarBuilder SetId(int id)
        {
            Id = id;
            return this;
        }

        public CarBuilder SetModelName(string modelName)
        {
            ModelName = modelName;
            return this;
        }

        public CarBuilder SetBrand(string brand)
        {
            Brand = brand;
            return this;
        }

        public CarBuilder SetPrice(int price)
        {
            Price = price;
            return this;
        }

        public CarBuilder SetMilage(int milage)
        {
            Milage = milage;
            return this;
        }

        public CarBuilder SetBatteryCapacity(int batteryCapacity)
        {
            BatteryCapacity = batteryCapacity;
            return this;
        }

        public CarBuilder SetBatteryStatus(int batteryStatus)
        {
            BatteryStatus = batteryStatus;
            return this;
        }

        public Car Build()
        {
            return new Car(Id, ModelName, Brand, Price, Milage, BatteryCapacity, BatteryStatus);
        }
    }
}
