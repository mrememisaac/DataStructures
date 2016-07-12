using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewOfLoops
{
    public class BinarySearch
    {
        public static void Main1(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

            int size = 20; int target = 10;
            //int.TryParse(Console.ReadLine(), out target);
            //int.TryParse(Console.ReadLine(), out size);

            //string[] input = Console.ReadLine().Split(' ');
            int[] ar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };// Array.ConvertAll(input, Int32.Parse);

            if (size < 1 || size > 1000)
            {
                return;
            }

            if (target < -1000 || target > 1000)
            {
                return;
            }
            Console.WriteLine("Target = " + target);
            Console.WriteLine(FindTarget(ar, 0, ar.Length, target));
            Console.ReadKey();
        }

        static int GetMidPoint(int start, int end)
        {
            return (start + end) / 2;
        }

        static int FindTarget(int[] ar, int start, int end, int target)
        {
            int midpoint = GetMidPoint(start, end);
            Console.WriteLine(String.Format("Start = {0} End = {1} Midpoint is {2} Value at Midpoint = {3} ", start, end, midpoint, ar[midpoint]));
            if (ar[midpoint] > target)
            {
                Console.WriteLine("Greater than");
                return FindTarget(ar, 0, midpoint - 1, target);
            }
            else if (ar[midpoint] < target)
            {
                Console.WriteLine("Less than");
                return FindTarget(ar, midpoint + 1, end, target);
            }

            Console.WriteLine("Equals");
            return midpoint;

            //return midpoint;
        }
    }
}
