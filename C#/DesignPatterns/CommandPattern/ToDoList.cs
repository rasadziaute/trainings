using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class ToDoList
    {
        public int Id { get; set; }
        public List<ToDoItem> ToDoItems { get; set; }
    }
}
