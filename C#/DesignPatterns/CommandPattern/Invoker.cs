using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    public class Invoker
    {
        public void Invoke(ICommand command, ToDoList list)
        {
            var item = list.ToDoItems.FirstOrDefault();
            command.Execute(list, item);
        }

    }
}
