using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.Formatting.BreakingLongLines
{
    public class MatricesHelper
    {
        public void MatrixCheck(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    if (matrix[i, k] == 0 || 
                        matrix[i + 1, k] == 0 ||
                        matrix[i, k + 1] == 0 || 
                        matrix[i + 1, k + 1] == 0)
                    {
                        // .....
                    }
                }
            }
        }
    }
}
