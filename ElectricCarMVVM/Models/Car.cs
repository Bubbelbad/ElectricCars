﻿using ElectricCarMVVM.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricCarMVVM.Models
{
    public class Car : ICar
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public string Brand { get; set; }
        public int Price { get; set; }
        public int Milage { get; set; }
        public int BatteryCapacity { get; set; }
        public int BatteryStatus { get; set; }

        public Car() { }

        public Car(int id, string modelName, string brand, int price, int milage, int batteryCapacity, int batteryStatus)
        {
            this.Id = id;
            this.ModelName = modelName;
            this.Brand = brand;
            this.Price = price;
            this.Milage = milage;
            this.BatteryCapacity = batteryCapacity;
            this.BatteryStatus = batteryStatus;
        }
    }
}
