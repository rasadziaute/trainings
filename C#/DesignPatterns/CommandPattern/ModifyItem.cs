using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    public class ModifyItem : ICommand
    {
        public void Execute(ToDoList list, ToDoItem item)
        {
            var existingItem = list.ToDoItems.Where(x => x.Id == item.Id).FirstOrDefault();
            existingItem.Item = item.Item;
            existingItem.Description = item.Description;
            existingItem.State = item.State;

        }
    }
}
