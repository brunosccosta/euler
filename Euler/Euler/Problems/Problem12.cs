using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem12 : IProblem
    {
        private List<int> _primes = new List<int>();

        private const int _sieveLength = 300000;

        public void Run()
        {
            CalculatePrimes();

            long current = 1;
            long triangleNumber = 1;
            while (CountHowManyDivisors(triangleNumber) < 500)
            {
                current++;
                triangleNumber += current;
            }

            Console.WriteLine(triangleNumber);
        }

        private void CalculatePrimes()
        {
            var sieve = new bool[_sieveLength];

            _primes.Add(2);
            for (int i = 0; i < _sieveLength; i++)
            {
                if (sieve[i] == false)
                {
                    var n = 3 + 2 * i;
                    _primes.Add(n);

                    for (int j = i+n; j < _sieveLength; j+=n)
                    {
                        sieve[j] = true;
                    }
                }
            }
        }

        private int CountHowManyDivisors(long num)
        {
            var countDivisors = 1;
            var currentPrime = 0;

            while (num > 1)
            {
                var prime = _primes[currentPrime];
                var timesCurrentPrime = 0;

                while (num % prime == 0)
                {
                    timesCurrentPrime++;
                    num = num / prime;
                }

                countDivisors = countDivisors * (timesCurrentPrime + 1);
                currentPrime++;
            }

            return countDivisors;
        }
    }
}
