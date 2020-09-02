using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfExcercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1 VARIANT #1
            Console.WriteLine("Enter password");

            //Conditional operator ? used in place of full if + else statement for something of this size
            //Print left side if readline equals secret123, right side if it does not equal
            Console.WriteLine(Console.ReadLine() == "secret123" ? "Access Granted!" : "Access Denied!");

            //#1 VARIANT #2
            Console.WriteLine("Enter password");

            string s_input = Console.ReadLine();
            //If statement to print value depending on input
            if (s_input == "secret123")
                Console.WriteLine("Access Granted!");
            else
                Console.WriteLine("Access Denied!");

            Console.ReadKey();
        }
    }
}
