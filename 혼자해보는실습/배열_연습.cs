using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class 배열_연습
    {
        static int[] CreateArray1(int nSize)
        {
            int[] Array1 = new int[nSize];

            for (int i = 0; i < Array1.Length; i++)
            {
                Array1[i] = i;
            }

            return Array1;
        }

        static int[,] CreateArray2(int nRow, int nCol)
        {
            int index = 0;
            int[,] Array2 = new int[nRow, nCol];

            for (int i = 0; i < nRow; i++)
            {
                for (int j = 0; j < nCol; j++)
                {
                    Array2[i, j] = index++;                 
                }
            }

            return Array2;
        }
        static void Main(string[] args)
        {
            int[] nArray1;
            int[,] nArray2;

            nArray1 = CreateArray1(5);
            nArray2 = CreateArray2(2, 3);

            for (int i = 0; i < nArray1.Length; i++)
            {
                Console.Write(nArray1[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(nArray2[i, j]);
                }
            }
            Console.WriteLine();
        }
    }
}
