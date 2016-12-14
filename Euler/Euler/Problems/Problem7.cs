using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem7 : IProblem
    {
        private const int _number = 10001;

        public void Run()
        {
            var primesFoundSoFar = 2;
            var candidateForPrime = 3;

            while (primesFoundSoFar < _number)
            {
                candidateForPrime += 2;
                if (IsPrime(candidateForPrime))
                {
                    primesFoundSoFar++;
                }
            }

            Console.WriteLine(candidateForPrime);
        }

        private bool IsPrime(long n)
        {
            var limit = Math.Floor(Math.Sqrt(n));
            for (long i = 2; i <= limit; i += 1)
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
