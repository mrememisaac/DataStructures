using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class InsertionSort
    {
        public static void Sort(int[] ar, int length)
        {
            for (int i = 1; i < length; i++)
            {
                int hole = i; //get a handle on the current pos
                int item = ar[i]; //get the item at the current pos

                //so long as we havent gotten to the start of the array
                //&
                //so long as the item left of the hole is greater than the current item
                while (hole > 0 && ar[hole - 1] > item)
                {
                    //move the left item into the hole
                    ar[hole] = ar[hole - 1]; 
                    
                    //shift the hole left
                    hole = hole - 1;
                }

                //if we get here, then we have either gotten to the start of the array 
                //or
                //the item left of the hole is smaller than the current item
                //in either case we have found our spot, so we insert
                ar[hole] = item;
            }
        }
    }
}
