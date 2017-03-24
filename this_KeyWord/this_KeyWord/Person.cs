using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace this_KeyWord
{
    class Person
    {
        public string name;
        public int age;

        public Person (string name,int age)   // constructor 
        {
            this.name = name;    //تعني انه اذا استخدمت نفس المتغير في دالة البناء و تريد ان تفهم الكومبايلر عدم الخلط بينهما  this 
                                //قبل متغير الكلاس لكي يفهم الكومبايلر هذا this  فإنك يجب ان تضع الكلمه المحجوزه 
            this.age = age;
        }

        public Person(string name)   // constructor 
        {
            this.name = name;
            
        }

        public void printme() { Console.WriteLine($"{name} ,{age}"); }
        
    }
}
