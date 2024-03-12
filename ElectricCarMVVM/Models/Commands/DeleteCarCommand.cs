using ElectricCarMVVM.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricCarMVVM.Models.Commands
{
    public class DeleteCarCommand : RelayCommand
    {
        public DeleteCarCommand(object? obj) : base(null, null)
        {
            _Execute = DeleteCar;
            _CanExecute = CanExecute;
        }

        private bool CanExecute(object? obj)
        {
            return true;
        }

        private void DeleteCar(object? obj)
        {
            DatabaseConnection instance = DatabaseConnection.Instance();
            instance.DeleteCar((CarProxy)obj);
        }
    }
}
