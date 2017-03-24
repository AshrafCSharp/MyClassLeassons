using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default_parametrizedConstructor
{
    class Person
    {
        public string name;
        public int age;

        // default Constructor .... non Parametrized
        public Person()
        {
            name = "Ashraf";
            age = 45;
        }

        // default Parametrized Constructor ....  
        public Person(string myname, int myage)
        {
            name = myname;
            age = myage;
        }

        // default Parametrized Constructor ....
        public Person(string myname2)
        {
            name = myname2;
        }
 
        // Class Method....................................................
        public void printing()
        {
            string msg;
            if (age == 0)
            {
                msg = "you Don't put an Age !";
                Console.WriteLine($"{name} , {msg}");
            }
            else
                Console.WriteLine($"{name} , {age}");


        }

    }
}
