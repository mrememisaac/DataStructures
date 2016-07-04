using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewOfLoops
{
    public class ProgramPhoneBook
    {
        static Dictionary<int, string> _phoneBook { get; set; }

        public static void MainOne(String[] args)
        {
            _phoneBook = new Dictionary<int, string>();

            int entriesCount = 0;

            while (entriesCount == 0 && entriesCount > 100000) //ensure that N > 0
            {
                int.TryParse(Console.ReadLine(), out entriesCount);
            }

            int count = 0;
            if (entriesCount > 0)
            {
                string input = Console.ReadLine();
                while (!String.IsNullOrEmpty(input))
                {
                    if (count < entriesCount) //add to phone book
                    {
                        char[] separator = new char[] { ' ' };
                        var entry = input.Split(separator);

                        count++; //keep track of the number of entries processed

                        if (entry != null)
                        {
                            int phoneNumber = 0;
                            if (entry.Length > 1)
                            {
                                if (int.TryParse(entry[1], out phoneNumber))
                                {
                                    _phoneBook.Add(phoneNumber, entry[0]);
                                }
                            }
                        }
                    }
                    else
                    {
                        //query phone book
                        QueryPhoneBook(input);
                    }
                    input = Console.ReadLine();
                }
            }
        }

        private static void QueryPhoneBook(string input)
        {
            //var result = _phoneBook.ElementAt(x => x.Value.Trim().Equals(input.Trim(), StringComparison.InvariantCultureIgnoreCase));
            //if (result.Key > 0)
            //{
            //    Console.WriteLine(String.Format("{0}={1}", result.Value, result.Key));
            //}
            //else
            //{
            //    Console.WriteLine("Not found");
            //}
        }
    }
}