using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Domain.Entities
{
    public class DateOfBirth
    {
        private int _day;
        private int _month;
        private int _year;
        public DateOfBirth(int day, int month, int year)
        {
            _day = day;
            _month = month;
            _year = year;
        }


        public static bool DateValidation(int day, int month, int year)
        {
            if (day > 31 || month > 12 || year < 1962)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string DisplayDate()
        {
            return $"{_day}/{_month}/{_year}";
        }
    }
}
