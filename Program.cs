using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Data_type
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring  of string, interger, a boolean and decimal
            string name = "Budha";
            int age = 50;
            bool isTall = true;
            double weight = 80.2;
            char initial = 'B';

            //print 
            Console.WriteLine("His name is " + name + " he is " + age + " it is " + isTall + " that he is tall");
            Console.WriteLine("His weight in kg's is " + weight + " his initial is " + initial);
           
            //freeze
            Console.ReadLine();
        }
    }
}
