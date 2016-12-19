using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem15 : IProblem
    {
        private const int _size = 20;

        private long[,] _matrix = new long[_size + 1, _size + 1];

        public void Run()
        {
            _matrix[_size, _size - 1] = 1;
            _matrix[_size - 1, _size] = 1;

            Console.WriteLine(Calculate(0, 0));
        }

        public long Calculate(int i, int j)
        {
            if (i > _size || j > _size)
            {
                return 0;
            }

            if (_matrix[i,j] != 0)
            {
                return _matrix[i, j];
            }

            var result = Calculate(i + 1, j) + Calculate(i, j + 1);
            _matrix[i, j] = result;

            return result;
        }
    }
}
