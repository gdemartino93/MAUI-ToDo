using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_ToDo.MVVM.Models
{
    public class Task
    {
        public string Name { get; set; }
        public bool IsCompleted { get; set; }
        public string? Color { get; set; }
        public int CategoryId { get; set; }
    }
}
