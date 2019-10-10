using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare and initialize some variables in calling method
            string[] strArray = new string[] { "one", "two", "three" };
            int someInt = 42;

            // print out values
            Console.WriteLine("values before method call");
            Console.WriteLine("someInt: {0}", someInt);
            foreach(string s in strArray)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            // call method
            myMethod(someInt, strArray);

            // print out values
            Console.ReadLine(); // waits for user input
            Console.WriteLine("values after method call");
            Console.WriteLine("someInt: {0}", someInt);
            foreach (string s in strArray)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            // demo overloading
            myMethod(strArray);

            // print out values
            Console.ReadLine(); // waits for user input
            Console.WriteLine("values after method call");
            Console.WriteLine("someInt: {0}", someInt);
            foreach (string s in strArray)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
        }

        // method that demonstrates call by value and call by reference
        static void myMethod(int arg1, string[] arg2)
        {
            arg1 = 99;
            arg2[1] = "twenty-two";
        }

        // part of overloading demo
        // same method as above, just different parameters
        static void myMethod(string[] arg2)
        {
            arg2[0] = "seven";
        }
    }
}
