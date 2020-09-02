using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //#2 Variant #1
            Console.WriteLine("Enter your age");
            //Parse the Readline to int then check if equal to or more than 18
            //Conditional Operator ? print left side if equal to or above 18, right side if below
            Console.WriteLine(int.Parse(Console.ReadLine()) >= 18 ? "Access Granted!" : "Acess Denied!");

            //2 Variant #2
            int age = 0;
            //TryParse for error handling & check if age is equal to or higher than 18
            if (int.TryParse(Console.ReadLine(), out age) && age >= 18)
                Console.WriteLine("Access Granted!");
            //else if conditions are not met (below 18 in this case)
            else
                Console.WriteLine("Access Denied!");

            Console.ReadKey();
        }
    }
}
