using ElectricCarMVVM.Commands;
using ElectricCarMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ElectricCarMVVM.ViewModel
{
    public class AddCarViewModel
    {
        public ICommand AddCarCommand { get; set; }

        public string? ModelName { get; set; }
        public string? Brand { get; set; }

        public AddCarViewModel()
        {
            AddCarCommand = new RelayCommand(AddUser, CanAddUser);
        }

        private bool CanAddUser(object obj)
        {
            return true;
        }

        private void AddUser(object obj)
        {
            DatabaseConnection db = DatabaseConnection.Instance();
            db.AddCar(new Car() { ModelName = ModelName, Brand = Brand});

        }

    }
}
