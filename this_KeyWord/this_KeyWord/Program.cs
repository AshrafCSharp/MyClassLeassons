using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace this_KeyWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Person myperson = new Person("Ashraf", 45);
            Person myperson1 = new Person("Taym");
            myperson.printme();

            myperson1.printme();

            Console.ReadKey();

        }
    }
}
