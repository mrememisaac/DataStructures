using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCup.Chapter1
{
    /// <summary>
    /// Given two string, write a method to decide if one is a permutation of the other
    /// 16 minutes
    /// </summary>
    public class Question3
    {
        public static void Main1(string[] args)
        {
            string arg1 = "toad";
            string arg2 = "doat";
            Console.WriteLine(IsPermutation(arg1, arg2));
            Console.ReadKey();
        }

        /// <summary>
        /// Check if all the chars in A are in B and the length is equal
        /// </summary>
        /// <param name="arg"></param>
        private static bool IsPermutation(string arg1, string arg2)
        {
            if (arg1.Length != arg2.Length)
            {
                return false;
            }
            bool contains = false;

            for (int i = 0; i < arg1.Length; i++)
            {
                char x = arg1[i];
                contains = arg2.Contains(x);
                if (contains == false)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
