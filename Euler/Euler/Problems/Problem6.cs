using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem6 : IProblem
    {
        private const int _limit = 100;

        public void Run()
        {
            long sumOfSquares = 0;
            int sum = 0;
            for (int i = 1; i <= _limit; i++)
            {
                sumOfSquares += i * i;
                sum += i;
            }

            long squareOfSum = sum * sum;

            Console.WriteLine(squareOfSum - sumOfSquares);
        }
    }
}
