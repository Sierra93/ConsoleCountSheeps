using System;
using System.Linq;

namespace ConsoleSleepSheep {
    class Program {
        public static void CountSheeps() { 
            bool[] sheeps = { true, false, true };
            var result =  sheeps.Count(s => s);
            Console.WriteLine(result);
        }
        static void Main(string[] args) {
            CountSheeps();
            Console.ReadKey();
        }
    }
}
