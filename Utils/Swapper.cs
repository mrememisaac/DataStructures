using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public static class Swapper
    {
        public static int Swap(int[] array, int left, int right)
        {
            int temp = array[right];
            array[right] = array[left];
            array[left] = temp;
            return temp;
        }
    }
}
