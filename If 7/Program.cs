using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mono.Reflection;
using System.Reflection;
using System.Reflection.Emit;

namespace If_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input 2 bools separated by space.");
            string[] input = Console.ReadLine().Split(' ');

            bool[] bools = new bool[2]
            {
                bool.Parse(input[0]),
                bool.Parse(input[1])
            };

            Console.WriteLine("!(x && y): {0}\n!x || !y: {1}\nAreEqual: {2}", new object[]
            {
                    Ver1(bools[0], bools[1]),
                    Ver2(bools[0], bools[1]),
                    AreEqual(bools[0], bools[1])
            });

            Console.ReadKey();
        }

        public static bool Ver1(bool x, bool y) =>
            !(x && y);
        
        public static bool Ver2(bool x, bool y) =>
            !x || !y;

        public static bool AreEqual(bool x, bool y) =>
            !(x && y) == !x || !y;
    }
}
