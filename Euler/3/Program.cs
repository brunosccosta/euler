using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 600851475143;

            Stopwatch watch = new Stopwatch();
            watch.Start();

            var factor = 2;
            while (number > 1)
            {
                if (number % factor == 0)
                {
                    number = number / factor;
                }
                else
                {
                    factor++;
                }
            }
            watch.Stop();
            
            Console.WriteLine(factor);

            Console.WriteLine("Took {0} milliseconds to solve it.", watch.ElapsedMilliseconds);
            Console.ReadLine();
        }

        static bool IsPrime(long n)
        {
            for (long i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
