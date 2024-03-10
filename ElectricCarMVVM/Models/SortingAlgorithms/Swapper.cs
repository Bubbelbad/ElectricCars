using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricCarMVVM.Models.SortingAlgorithms
{
    public class Swapper
    {
        public void Swap(int[] array, int indexA, int indexB)
        {
            int temp = array[indexA];
            array[indexA] = array[indexB];
            array[indexB] = temp;
        }
    }
}
