using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("What do you want to see?\n1. Forests\n2. Mountains\n3. Cities");

                string inputOne = Console.ReadLine();

                if (inputOne.ToLower() == "forests" || inputOne == "1")
                    Console.WriteLine("You should visit Småland\n");

                else if (inputOne.ToLower() == "mountains" || inputOne == "2")
                    Console.WriteLine("You should visit Lappland\n");

                else if (inputOne.ToLower() == "cities" || inputOne == "3")
                {
                    Console.WriteLine("Do you enjoy puns?\n1. Yes\n2. No");
                    string inputTwo = Console.ReadLine();

                    if (inputTwo.ToLower() == "yes" || inputTwo == "1")
                        Console.WriteLine("You should visit Gothenburg\n");

                    else if (inputTwo.ToLower() == "no" || inputTwo == "2")
                        Console.WriteLine("You should visit Stockholm\n");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input,try again!");
                }
            }
        }
    }
}
