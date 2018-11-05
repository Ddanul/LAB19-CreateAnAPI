﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class ToDoItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public int ToDoListID { get; set; }
    }
}