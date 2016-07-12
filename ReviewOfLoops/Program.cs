using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Algorithms
{
    public class Program
    {
        static void Main(String[] args)
        {
            int[] ar = new int[] { 9, 8, 1, 2, 6, 4, 7, 5, 3 };
            QuickSort.Sort(ar, 0, ar.Length-1);
            Printer.Print(ar);
            Console.ReadKey();
        }        
    }    
}
