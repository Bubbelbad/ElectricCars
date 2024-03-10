using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricCarMVVM.Models.SortingAlgorithms
{
    public class InsertionSort
    {
        public void Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int valueToSort = array[i];
                int j = i;
                while (j > 0 && valueToSort < array[j - 1])
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = valueToSort;
            }
        }
    }
}
