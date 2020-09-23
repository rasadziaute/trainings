using System;
using System.Collections.Generic;
using System.Text;

namespace BankApplication
{
    public class DateofBirth
    {
        private int _day;
        private int _month;
        private int _year;

        public void AssignValue(int day, int month, int year)
        {
            _day = day;
            _month = month;
            _year = year;
        }


        public bool DateValidation()
        {
            if (_day > 31 || _month > 12 || _year < 1962)
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
