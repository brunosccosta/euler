using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem2 : IProblem
    {
        private const int _target = 4000000; //4m

        private int[] _memory = new int[_target];
        
        public void Run()
        {
            _memory[0] = 1;
            _memory[1] = 1;

            int sum = 0;
            int currentFib = 1;

            var fib = Fib(currentFib);
            while (fib < _target)
            {
                if (fib % 2 == 0)
                {
                    sum += fib;
                }

                currentFib++;
                fib = Fib(currentFib);
            }

            Console.WriteLine(sum);
        }

        private int Fib(int n)
        {
            if (_memory[n] != 0)
                return _memory[n];

            var fib = Fib(n - 1) + Fib(n - 2);
            _memory[n] = fib;

            return fib;
        }
    }
}
