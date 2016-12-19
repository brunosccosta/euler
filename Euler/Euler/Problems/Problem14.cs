using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem14 : IProblem
    {
        private const int _target = 1000000;

        private long[] _memory = new long[3*_target];

        public void Run()
        {
            _memory[1] = 1;

            long longestSequence = 0;
            long numberOfLongestSequence = 0;
            for (int i = 1; i <= _target; i++)
            {
                var curr = SizeCollatzSequence(i);
                if (curr > longestSequence)
                {
                    longestSequence = curr;
                    numberOfLongestSequence = i;
                }
            }

            Console.WriteLine(numberOfLongestSequence);
        }

        public long SizeCollatzSequence(long n)
        {
            if (n < _memory.Length && _memory[n] != 0)
            {
                return _memory[n];
            }

            long result = 0;
            if (n % 2 == 0)
            {
                result = 1 + SizeCollatzSequence(n / 2);
            }
            else
            {
                result = 1 + SizeCollatzSequence(3 * n + 1);
            }

            if (n < _memory.Length)
            {
                _memory[n] = result;
            }
            
            return result;
        }
    }
}
