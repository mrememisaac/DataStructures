using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewOfLoops
{    
    class Program2DArray
    {
        static void MainOld(string[] args)
        {
            int[][] arr = new int[6][];
            arr[0] = new int[] { -1, -1, 0, -9, -2, -2 };//{ 1, 1, 1, 0, 0, 0 };
            arr[1] = new int[] { -2, -1, -6, -8, -2, -5 };//{ 0, 1, 0, 0, 0, 0 };
            arr[2] = new int[] { -1, -1, -1, -2, -3, -4 };//{ 1, 1, 1, 0, 0, 0 };
            arr[3] = new int[] { -1, -9, -2, -4, -4, -5 }; //{ 0, 0, 2, -4, -4, 0 };
            arr[4] = new int[] { -7, -3, -3, -2, -9, -9 };//{ 0, 0, 0, -2, 9, 0 };
            arr[5] = new int[] { -1, -3, -1, -2, -4, -5 };//{ 0, 0, -1, -9, 9,90 };

            /*
             * for each row
             * if not row 4
             * go to starting cell 
             * add first 3 cells
             * add the center cell immediately below
             * add the first 3 cells of the 3rd row
             * repeat until cell 4
             */
            int highest = Int32.MinValue, sum = 0;// sec = 0, third = 0, fourth = 0;
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    int counter = 0;

                    //add first three cells
                    while (counter < 3)
                    {
                        Console.Write(arr[row][col + counter] + " + ");
                        sum += arr[row][col + counter];
                        counter++;
                    }

                    //add center cell imediately below
                    sum += arr[row + 1][col + 1];
                    Console.Write(arr[row + 1][col + 1] + " + ");

                    //add the first 3 cells of the third row
                    counter = 0; //reset counter
                    if (row + 2 < 6)
                    {
                        while (counter < 3)
                        {
                            Console.Write(arr[row + 2][col + counter] + " = ");
                            sum += arr[row + 2][col + counter];
                            counter++;
                        }
                    }
                    if (sum > highest)
                    {
                        highest = sum; //update highest                       
                    }
                    Console.Write(sum);
                    Console.WriteLine();
                    sum = 0; //reset sum

                }
            }
            Console.WriteLine(highest);
            Console.ReadLine();
        }
    }
}
