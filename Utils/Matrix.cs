using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public static class Matrix
    {
        public static int? UpdateCell(int[][] ar, int row, int col, int value)
        {
            for (int i = 0; i < ar.Length; i++)
            {
                if (i == row)
                {
                    for (int j = 0; j < ar[i].Length; j++)
                    {
                        if (j == col)
                        {
                            ar[i][j] = value;
                        }
                    }
                }
            }
            return null;
        }

        public static int[] GetRow(int[][] ar, int row)
        {
            for (int i = 0; i < ar[0].Length; i++)
            {
                if (i == row)
                {
                    return ar[i];
                }
            }
            return null;
        }
        public static int[] GetRow(int[,] ar, int row)
        {
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                if (i == row)
                {
                    //return ar[i];
                }
            }
            return null;
        }

        public static int[] GetCol(int[][] ar, int col)
        {
            List<int> values = new List<int>();

            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = 0; j < ar[0].Length; j++)
                {
                    if (j == col)
                    {
                        values.Add(ar[i][j]);
                    }
                }
            }
            return values.ToArray();
        }

        public static void UpdateCol(int[][] ar, int col, int value, int row)
        {
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i][col] = value;
            }
        }

        public static int? GetCell(int[][] ar, int row, int col)
        {
            for (int i = 0; i < ar[0].Length; i++)
            {
                if (i == row)
                {
                    for (int j = 0; j < ar[0].Length; j++)
                    {
                        if (j == col)
                        {
                            return ar[i][j];
                        }
                    }
                }
            }
            return null;
        }

        static public int[][] Create(int size)
        {
            int[][] matrix = new int[size][];
            int ct = 0;
            for (int i = 0; i < size; i++)
            {
                int[] row = new int[size];
                for (int c = size - 1; c >= 0; c--)
                {
                    ct++;
                    row[c] = ct;
                }
                matrix[i] = row;
            }
            return matrix;
        }

        static public int[,] Create2D(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            int ct = -1;
            for (int i = 0; i < rows; i++)
            {
                //int[] row = new int[cols];
                for (int c = cols - 1; c >= 0; c--)
                {
                    ct++;
                    matrix[i, c] = ct;
                }
                //matrix[i] = row;
            }
            return matrix;
        }

        static public int[][] Create(int rows, int cols)
        {
            int[][] matrix = new int[rows][];
            int ct = -1;
            for (int i = 0; i < rows; i++)
            {
                int[] row = new int[cols];
                for (int c = cols - 1; c >= 0; c--)
                {
                    ct++;
                    if (ct == 10) ct = 0;
                    row[c] = ct;
                }
                matrix[i] = row;
            }
            return matrix;
        }
    }
}
