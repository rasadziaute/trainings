using System;
using System.Collections.Generic;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoker = new Invoker();
            var addItem = new AddItem();
            var modifyItem = new ModifyItem();

            invoker.Invoke(addItem, new ToDoList()
            {
                Id = 1,
                ToDoItems = new List<ToDoItem>() { new ToDoItem() { Id = 1, Item = "Clean the house", Description = "Take a vacuum and clean", State = "In Progress" } }
            });

            invoker.Invoke(modifyItem, new ToDoList()
            {
                Id = 1,
                ToDoItems = new List<ToDoItem>() { new ToDoItem() { Id = 1, Item = "Clean the house", Description = "Take a vacuum and clean", State = "Done" } }
            });

        }
    }
}
