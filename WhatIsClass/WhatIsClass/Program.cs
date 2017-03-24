using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle myVehicle = new Vehicle();
            myVehicle.manufacturer="Toyota";
            myVehicle.model = "Camry";
            myVehicle.color = "Blue";
            myVehicle.enginSize = 4;
            myVehicle.painting();
            Console.WriteLine();
            myVehicle.movement();
            Console.ReadKey();

        }
    }
}
