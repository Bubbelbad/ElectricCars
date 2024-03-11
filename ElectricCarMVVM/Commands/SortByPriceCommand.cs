using ElectricCarMVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ElectricCarMVVM.Commands
{
    public class SortByPriceCommand : RelayCommand
    {
        ObservableCollection<CarProxy> carProxy;
        public SortByPriceCommand(ObservableCollection<CarProxy> proxy) : base(null, null)
        {
            _Execute = Execute;
            _CanExecute = CanExecute;
            this.carProxy = proxy;
        }

        private bool CanExecute(object? obj)
        {
            return true;
        }

        //INSERTION SORT ALGORITHM
        private void Execute(object? obj)
        {
            for (int i = 0; i < carProxy.Count; i++)
            {
                int valueToSort = carProxy[i].Price;
                CarProxy itemToSort = carProxy[i];
                int j = i;
                while (j > 0 && valueToSort < carProxy[j - 1].Price)
                {
                    carProxy[j] = carProxy[j - 1];
                    j--;
                }
                carProxy[j] = itemToSort;
            }
        }
    }
}
