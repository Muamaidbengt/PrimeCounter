using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var clock = Stopwatch.StartNew();
            var target = 10001;
            var counter = new PrimeCounter(target);
            Console.WriteLine($"Prime #{target} is {counter.LargestPrime}.");
            Console.WriteLine($"Calculated in {clock.ElapsedMilliseconds}ms");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
