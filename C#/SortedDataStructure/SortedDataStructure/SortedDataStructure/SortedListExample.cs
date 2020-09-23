using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SortedDataStructure
{
    public class SortedListExample
    {
        public void RunSortedListExample()
        {
            var sortedList = new SortedList<string, string>();

            sortedList.Add("txt", "MyTextFile");
            sortedList.Add("xls", "MyExcelFile");
            sortedList.Add("csv", "MyCsvFile");
            sortedList.Add("sql", "MySqlFile");

            Display(sortedList);

            Console.WriteLine("Contains txt extension: " + sortedList.ContainsKey("txt"));
            Console.WriteLine("Contains csv file: " + sortedList.ContainsValue("MyCsvFile"));

            sortedList["xls"] = "AnotherExcelFile";

            sortedList["xlsx"] = "SomeExcelFile";

            Display(sortedList);


            sortedList.Remove("xls");
            Display(sortedList);

            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine("Key: {0}, file name {1}", sortedList.Keys[i], sortedList.Values[1]);
            }


            sortedList.Clear();

            Console.ReadKey();
        }

        private void Display(SortedList<string, string> sortedList)
        {
            foreach (var item in sortedList)
            {
                Console.WriteLine("Key: {0}, file name {1}", item.Key, item.Value);
            }
        }
    }
}
