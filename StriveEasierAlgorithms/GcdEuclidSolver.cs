using System;
using System.Collections.Generic;
using System.Text;

namespace StriveEasierAlgorithms
{
    class GcdEuclidSolver
    {
        /// <summary>
        /// Almost 3000 years old and it still runs like a madman
        /// </summary>
        public int FindGreatestCommonDivisor(int x, int y)
        {
            while ((x != 0) && (y != 0))
            {
                if (x > y)
                    x = x % y;
                else
                    y = y % x;
            }

            return x == 0 ? y : x;
        }
    }
}
