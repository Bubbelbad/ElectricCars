using ElectricCarMVVM.Commands;
using ElectricCarMVVM.Models.SortingAlgorithms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricCarMVVM.Models.Commands
{
    public class QuickSortCommand : RelayCommand
    {
        //This class sorts the proxys by brand in MainWindow

        ObservableCollection<CarProxy> carProxies;
        Swapper swapper;

        public QuickSortCommand(ObservableCollection<CarProxy> proxies) : base (null, null)
        {
            _Execute = Execute;
            _CanExecute = CanExecute;
            this.carProxies = proxies;
            this.swapper = new Swapper();
        }

        //Utilizing quick sort algorithm for sorting: 
        private void Execute(object? obj)
        {
            Sort(carProxies, 0, carProxies.Count -1);
        }


        private void Sort(ObservableCollection<CarProxy> carProxies, int start, int end)
        {
            if (start < end)
            {
                int pivotIndex = Partition(carProxies, start, end);
                Sort(carProxies, start, pivotIndex - 1);
                Sort(carProxies, pivotIndex +1, end);
            }
        }

        private int Partition(ObservableCollection<CarProxy> carProxies, int start, int end)
        {
            string pivot = carProxies[end].ModelName;
            int pivotIndex = start;
            for (int i = start; i < end; i++)
            {
                if (pivot.CompareTo(carProxies[i].ModelName) == 1)
                {
                    swapper.Swap(carProxies, i, pivotIndex);
                    pivotIndex++;
                }
            }
            swapper.Swap(carProxies, end, pivotIndex);
            return pivotIndex; 
        }

        private bool CanExecute(object? obj)
        {
            return true;
        }
    }
}

