using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem3 : IProblem
    {
        public void Run()
        {
            var number = 600851475143;

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

            Console.WriteLine(factor);
        }

        private bool IsPrime(long n)
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
