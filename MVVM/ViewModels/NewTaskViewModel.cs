using MAUI_ToDo.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = MAUI_ToDo.MVVM.Models.Task;

namespace MAUI_ToDo.MVVM.ViewModels
{
    public class NewTaskViewModel
    {
        public string Task { get; set; }
        public ObservableCollection<Task> Tasks { get; set; }
        public ObservableCollection<Category> Categories { get; set; }

    }
}
