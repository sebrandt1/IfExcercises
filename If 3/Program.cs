using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //#3.1 Variant #1
            Console.WriteLine("Input temperature in celsius");

            int temp1 = int.Parse(Console.ReadLine());
            //set string msg to whichever side matches the condition (more than 18 degrees and below 26 degrees)
            string msg = temp1 >= 18 && temp1 <= 26 ? "Appropriate temperature" : "Unacceptable temperature";
            Console.WriteLine(msg);


            
            //#3.1 Variant #2
            Console.WriteLine("Input temperature in celsius");

            int temp2 = int.Parse(Console.ReadLine());
            bool acceptable = temp2 >= 18 && temp2 <= 26;

            if (acceptable)
                Console.WriteLine("Appropriate temperature");
            else
                Console.WriteLine("Unacceptable temperature");



            //#3.2
            Console.WriteLine("Input temperature in celsius");

            int temp3 = int.Parse(Console.ReadLine());

            //if more than 26
            if (temp3 > 26)
                Console.WriteLine("Temperature too high");
            //if below 18
            else if (temp3 < 18)
                Console.WriteLine("Temperature too low");
                
            Console.ReadKey();
        }
    }
}
