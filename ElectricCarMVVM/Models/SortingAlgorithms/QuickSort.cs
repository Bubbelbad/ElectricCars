using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricCarMVVM.Models.SortingAlgorithms
{
    public class QuickSort
    {
        Swapper swapper = new Swapper();

        private void Sort(int[] array, int start, int end)
        {
            if (start < end)
            {
                int pivotIndex = Partition(array, start, end);
                Sort(array, start, pivotIndex - 1);
                Sort(array, pivotIndex + 1, end);
            }
        }

        private int Partition(int[] array, int start, int end)
        {
            int pivot = array[end];
            int pivotIndex = start;
            for (int i = start; i < end; i++)
            {
                if (array[i] < pivot)
                {
                    swapper.Swap(array, i, pivotIndex);
                    pivotIndex++;
                }
            }
            swapper.Swap(array, pivotIndex, end);
            return pivotIndex;
        }
    }
}
