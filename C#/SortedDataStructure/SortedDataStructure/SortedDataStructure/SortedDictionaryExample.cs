using System;
using System.Collections.Generic;
using System.Text;

namespace SortedDataStructure
{
    public class SortedDictionaryExample
    {
        public void RunSortedDictionaryExample()
        {
            var sortedDictionary = new SortedDictionary<string, string>();

            sortedDictionary.Add("txt", "MyTextFile");
            sortedDictionary.Add("xls", "MyExcelFile");
            sortedDictionary.Add("csv", "MyCsvFile");
            sortedDictionary.Add("sql", "MySqlFile");

            Display(sortedDictionary);

            Console.WriteLine("Contains txt extension: " + sortedDictionary.ContainsKey("txt"));
            Console.WriteLine("Contains csv file: " + sortedDictionary.ContainsValue("MyCsvFile"));

            sortedDictionary["xls"] = "AnotherExcelFile";

            sortedDictionary["xlsx"] = "SomeExcelFile";

            Display(sortedDictionary);

            SortedDictionary<string, string>.ValueCollection valueCollection = sortedDictionary.Values;

            Console.WriteLine();
            foreach (var values in valueCollection)
            {
                Console.WriteLine("File names {0}", values);
            }

            SortedDictionary<string, string>.KeyCollection keyCollection = sortedDictionary.Keys;

            Console.WriteLine();
            foreach (var keys in keyCollection)
            {
                Console.WriteLine("File extensions {0}", keys);
            }

            sortedDictionary.Remove("xls");
            Display(sortedDictionary);

            var fileName = "";
            sortedDictionary.TryGetValue("csv", out fileName);
            Console.WriteLine("File Name " + fileName);

            sortedDictionary.Clear();

            Console.ReadKey();
        }

        private void Display(SortedDictionary<string, string> sortedDictionary)
        {
            foreach (var item in sortedDictionary)
            {
                Console.WriteLine("Key: {0}, file name {1}", item.Key, item.Value);
            }
        }

    }
}
