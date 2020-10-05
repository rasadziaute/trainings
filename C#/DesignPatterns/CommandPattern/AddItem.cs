using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class AddItem : ICommand
    {
        public void Execute(ToDoList list, ToDoItem item)
        {
            list.ToDoItems.Add(item);
        }
    }
}
