using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default_parametrizedConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            string aaa = "AYHAM";
            int ggg = 10;

            Person myperson = new Person();
            Person myperson1 = new Person(aaa,ggg);
            Person myperson2 = new Person("Taym");

            myperson.printing();// the call method

            myperson.name = "Mohamed";
            myperson.age = 15;
            myperson.printing();  // the same call method but we change the properties name & age 

            myperson1.printing();

            myperson2.printing();

            Console.ReadKey();

        }
    }
}
