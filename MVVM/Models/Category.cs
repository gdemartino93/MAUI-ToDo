﻿using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_ToDo.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int PendingTasks { get; set; }
        public float Percentage { get; set; }
        public bool IsSelected { get; set; }
    }
}
