using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Lesson7Project1
{
    static class Dynamic
    {
        public static int NumberOptions(int n, int m)
        {
            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
                matrix[i, 0] = 1;

            for (int i = 0; i < m; i++)
                matrix[0, i] = 1;

            for (int i = 1; i < n; i++)
                for (int j = 1; j < m; j++)
                    matrix[i, j] = matrix[i, j - 1] + matrix[i - 1, j];

            return matrix[n - 1, m - 1];
        }


        //Ckn; n = N + M - 2; k = N - 1

        public static BigInteger NumberOptionsFast(int n, int m)
        {
            int _n = n + m - 2;
            int _k = n - 1;

            BigInteger kFac = 1;
            BigInteger nNotFullFac = 1;

            int i;

            for (i = 2; i <= _k; i++)
                kFac *= i;

            for (; i <= _n; i++)
                nNotFullFac *= i;

            return nNotFullFac / kFac;
        }
    }
}
