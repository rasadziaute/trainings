using System;
using System.Collections.Generic;

namespace SortedDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            var sortedDictionary = new SortedDictionaryExample();

            sortedDictionary.RunSortedDictionaryExample();


            var sortedList = new SortedListExample();

            sortedList.RunSortedListExample();

            var hashsetExample = new HashSetExample();

            hashsetExample.RunHashSetExample();

            Console.ReadLine();


        }

    }
}
