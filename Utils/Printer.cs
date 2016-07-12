using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public static class Printer
    {
        public static void Print(int[][] ar)
        {
            for (int i = 0; i < ar.Length; i++)
            {
                Print(ar[i]);
            }
            Console.WriteLine();
        }

        public static void Print(int[,] ar)
        {
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    Print(ar[i, j].ToString());
                }
            }
            Console.WriteLine();
        }

        public static void Print(int[] ar)
        {
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] < 10)
                {
                    Console.Write(" " + ar[i] + " ");
                }
                else
                {
                    Console.Write(ar[i] + " ");
                }
            }
            Console.WriteLine();            
        }

        public static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
