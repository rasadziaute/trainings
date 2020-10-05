using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class DateGenerator
    {
        private DateGenerator()
        {
        }
        private static DateGenerator instance = null;
        public static DateGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DateGenerator();
                }
                return instance;
            }
        }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public DateTime DisplayDate()
        {
            return DateTime.Parse($"{Year}/{Month}/{Day}");
        }
    }

}
