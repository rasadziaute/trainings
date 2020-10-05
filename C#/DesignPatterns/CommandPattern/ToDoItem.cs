using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public string Description { get; set; }
        public string State { get; set; }
    }
}
