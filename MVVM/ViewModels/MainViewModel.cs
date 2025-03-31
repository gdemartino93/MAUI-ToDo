using MAUI_ToDo.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_ToDo.MVVM.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<Category> Categories { get; set; }
        public MainViewModel()
        {
            FillData();
        }

        private void FillData()
        {
            Categories = new ObservableCollection<Category>
            {
                new Category
                {
                    Id = 1,
                    Name = ".NET Maui",
                    Color = "#f44336"

                },
                new Category
                {
                    Id = 2,
                    Name = "Certificazioni Azure",
                    Color = "#e69138"
                },
                new Category
                {
                    Id = 3,
                    Name = "Studio altro",
                    Color = "#8e7cc3"
                }
            };
        }
    }
}
