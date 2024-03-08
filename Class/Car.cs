using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Car:CarDetail
    {
        public string color;
        public int speed;
        public double enginePower;
        public char condition;
        public int price;
        public int year;
        public string brand;

        public int YEAR
        {
            get { return year; }
            set { year = Math.Abs( value); }
        }
        public string BRAND
        {
            get { return brand; }
            set { brand = value.ToUpper(); }
        }
    }
}
