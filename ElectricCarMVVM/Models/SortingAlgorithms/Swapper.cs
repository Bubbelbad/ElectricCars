using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricCarMVVM.Models.SortingAlgorithms
{
    public class Swapper
    {
        public void Swap(ObservableCollection<CarProxy> collection, int indexA, int indexB)
        {
            CarProxy temp = collection[indexA];
            collection[indexA] = collection[indexB];
            collection[indexB] = temp;
        }
    }
}
