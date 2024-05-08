using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    class exa
    {
        public int MaximalSquare(char[][] matrix)
        {
            int[][] arr = new int[matrix.Length][];
            for (int i = 1; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    arr[i-1][j] = matrix[i][j] ^ matrix[i - 1][j];
                }

            }
            return 0;
        }
    }
}
