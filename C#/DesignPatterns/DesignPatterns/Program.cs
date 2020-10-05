using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            DateGenerator.Instance.Year = 2020;
            DateGenerator.Instance.Month = 10;
            DateGenerator.Instance.Day = 2;

            Console.WriteLine(DateGenerator.Instance.DisplayDate());

            DateGenerator.Instance.Day = 3;

            Console.WriteLine(DateGenerator.Instance.DisplayDate());

            Console.ReadLine();
        }
    }
}
