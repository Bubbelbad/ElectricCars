using ElectricCarMVVM.Models;
using ElectricCarMVVM.Models.SortingAlgorithms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricCarMVVM.Commands
{
    public class SortByBrandCommand : RelayCommand
    {
        //This class sorts the proxys by brand in MainWindow

        ObservableCollection<CarProxy> collection;
        Swapper swapper;

        public SortByBrandCommand(ObservableCollection<CarProxy> collection) : base (null, null)
        {
            _Execute = Execute;
            _CanExecute = CanExecute;
            this.collection = collection;
            this.swapper = new Swapper();
        }

        //BUBBLE SORT ALGORITHM:
        private void Execute(object? obj)
        {
            for (int i = collection.Count - 1; i > 0; i--)
            {
                bool sorted = true;
                for (int j = 0; j < i; j++)
                {
                    if (collection[j].Brand.CompareTo(collection[j + 1].Brand) == 1)
                    {
                        swapper.Swap(collection, j, j + 1);
                        sorted = false;
                    }
                }
                if (sorted)
                {
                    return;
                }
            }
        }

        private bool CanExecute(object? obj)
        {
            return true;
        }
    }
}
