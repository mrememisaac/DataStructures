using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCup.Chapter1
{
    /// <summary>
    /// Implement an algorithm to determine if a string has all unique characters. What if you cannot use additional data structures
    /// </summary>
    public class Question1
    {
        static void Main1(string[] args)
        {
            /*
             * for each char
             * compare to all the other chars
             * if 
             */
            String arg = "Emem";//"Implement an algorithm to determine if a string has all unique characters. What if you cannot use additional data structures";
            Console.WriteLine(IsUnique(arg));
            Console.ReadKey();
        }

        /// <summary>
        /// Started @ 6:49am finished @ 7:09am
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        private static bool IsUnique(string arg)
        {
            //foreach char
            for (int i = 0; i < arg.Length; i++)
            {
                //search for another occurence of it the string
                for (int j = i + 1; j < arg.Length; j++)
                {
                    //if found return false
                    if (arg[i] == arg[j])
                    {
                        return false;
                    }
                }
            }            
            //if we get here then the string is unique
            return true;
        }
    }
}
