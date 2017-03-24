using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsClass
{
    class Vehicle
    {
        public string manufacturer;
        public string model;
        public string color;
        public int enginSize;

        public Vehicle()  // This is the Constructor  ..... it must be the same CLASS name .
        {

        }
        public void painting()
        {
            Console.WriteLine("I'm Painting Method from Vehicle Class !!!");
        }
        public void movement()
        {
            Console.WriteLine("I'm movement Method from Vehicle Class !!!");
        }

    }
}
