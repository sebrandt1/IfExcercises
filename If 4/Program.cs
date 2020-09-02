using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //#4
            Console.WriteLine("Input your age, country of birth & amount of times you've been president");
            Console.WriteLine("Each input should be separated by a blank space, example: \"24-USA-0\"");

            //get user input and separate them into 3 different strings by splitting after dash
            string[] input = Console.ReadLine().Split('-');

            Person p = new Person()
            {
                age = int.Parse(input[0]),
                country = input[1],
                presCount = int.Parse(input[0])
            };

            bool conditions = p.age >= 35 && p.country.ToLower() == "usa" && p.presCount < 1;
            string msg = conditions ? "You can be president!" : "Unfortunately, you cannot be president";

            Console.WriteLine(msg);

            Console.ReadLine();
        }
    }
    public struct Person
    {
        public int age;
        public int presCount;
        public string country;
    }
}
