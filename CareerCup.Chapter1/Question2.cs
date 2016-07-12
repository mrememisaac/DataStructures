using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCup.Chapter1
{
    /// <summary>
    /// Implement a function void Reverse(string arg) that reveses a string
    /// Implemented in 5 Minutes
    /// </summary>
    public class Question2
    {
        public static void Main1(String[] args)
        {
            string arg = "daoT";
            Reverse(arg);
            Console.ReadKey();
        }

        private static void Reverse(string arg)
        {
            for (int i = arg.Length-1; i >= 0; i--)
            {
                Console.Write(arg[i]);
            }
        }
    }
}
