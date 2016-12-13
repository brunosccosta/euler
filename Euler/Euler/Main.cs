using Euler.Problems;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Euler
    {
        static void Main(string[] args)
        {
            var watch = new Stopwatch();
            watch.Start();

            var program = new Problem5();
            program.Run();

            watch.Stop();
            Console.WriteLine("Took {0} milliseconds to solve it.", watch.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
