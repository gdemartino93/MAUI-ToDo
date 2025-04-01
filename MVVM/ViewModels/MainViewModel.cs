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
    public class MainViewModel
    {
        public ObservableCollection<Category> Categories { get; set; }
        public ObservableCollection<Task> Tasks { get; set; }
        public MainViewModel()
        {
            FillData();
            UpdateData();
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
            Tasks = new ObservableCollection<Models.Task>
            {
                new Task
                {
                    Name = "AZ-900",
                    IsCompleted = true,
                    CategoryId = 2
                },
                new Task
                {
                    Name = "AZ-204",
                    IsCompleted = false,
                    CategoryId = 2
                },
                new Task
                {
                    Name = "Creare app per X",
                    IsCompleted = false,
                    CategoryId = 1
                },
                new Task
                {
                    Name = "AI",
                    IsCompleted = false,
                    CategoryId = 3
                }
            };
        }
        public void UpdateData()
        {
            foreach (var category in Categories)
            {
                IEnumerable<Task> tasks = Tasks.Where(t => t.CategoryId == category.Id);
                IEnumerable<Task> tasksCompleted = tasks.Where(t => t.IsCompleted);
                IEnumerable<Task> tasksNotCompleted = tasks.Where(t => !t.IsCompleted);

                category.PendingTasks = tasksNotCompleted.Count();
                category.Percentage = (float)tasksCompleted.Count() / (float)tasks.Count();

                foreach (var task in Tasks)
                {
                    string? categoryColor = Categories.Where(c => c.Id == task.CategoryId).Select(c => c.Color).FirstOrDefault();
                    task.Color = categoryColor;
                }

            }
        }
    }
}
