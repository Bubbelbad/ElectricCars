using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ElectricCarMVVM.Models;

namespace ElectricCarMVVM.Models.SortingAlgorithms
{
    public class Converter
    {
        public Converter()  { }

        public int[] Convert()
        {
            DatabaseConnection db = DatabaseConnection.Instance();
            ObservableCollection <CarProxy> proxy = db.GetProxy();
            int[] array = new int[proxy.Count];

            for (int i = 0; i < proxy.Count; i++)
            {
                array[i] = proxy[i].Price;
            }
            return array;
        }
    }
}
