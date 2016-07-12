using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewOfLoops
{
    class ContestProgram
    {
        static int prelimContests = 0;
        static int maxNoOfImportantLosses = 0;
        static int balance = 0;

        public static void Main1(string[] args)
        {
            string[] inp = "6 3".Split(' ');
            //string[] inp1 = "6 3 5 1 2 1 1 1 8 1 10 0 5 0".Split(' ');
            //string[] NandK = Console.ReadLine().Split(' ');
            //int.TryParse(NandK[0], out prelimContests);
            //int.TryParse(NandK[1], out maxNoOfImportantLosses);
            //if (prelimContests < 0 || prelimContests > 100) return;
            //if (maxNoOfImportantLosses < 0 || maxNoOfImportantLosses > prelimContests) return;

            //string[] NandK = Console.ReadLine().Split(' ');
            int.TryParse(inp[0], out prelimContests);
            int.TryParse(inp[1], out maxNoOfImportantLosses);
            if (prelimContests < 0 || prelimContests > 100) return;
            if (maxNoOfImportantLosses < 0 || maxNoOfImportantLosses > prelimContests) return;

            List<Contest> contests = new List<Contest>();
            //for (int i = 0; i < prelimContests; i++)
            //{
            //    int luck = 0, importance = 0;
            //    //string[] input = Console.ReadLine().Split(' ');
            //    int.TryParse(inp[i+2], out luck); //int.TryParse(input[0], out luck);
            //    int.TryParse(inp[i+3], out importance);//int.TryParse(input[1], out importance);
            //    if (luck < 0 || luck > 10000) return;
            //    if (importance < 0 || importance > 1) return;
            //    //contests[i] = new Contest(){ Rating = importance, Luck = luck};
            //    contests.Add(new Contest() { Rating = importance, Luck = luck });
            //}
            contests.Add(new Contest() { Luck = 5, Rating = 1 });
            contests.Add(new Contest() { Luck = 2, Rating = 1 });
            contests.Add(new Contest() { Luck = 1, Rating = 1 });
            contests.Add(new Contest() { Luck = 8, Rating = 1 });
            contests.Add(new Contest() { Luck = 10, Rating = 0 });
            contests.Add(new Contest() { Luck = 5, Rating = 0 });

            var notImportant = contests.OrderBy(x => x.Luck).Where(x => x.Rating == 0);

            //Loop through all the unimportant and loose them for max luck balance
            foreach (var item in notImportant)
            {
                balance += item.Lose();
            }

            var important = contests.Where(x => x.Rating == 1).OrderByDescending(x => x.Luck);
            int noLost = 0;
            foreach (var item in important)
            {
                if (noLost < maxNoOfImportantLosses)
                {
                    balance += item.Lose();
                    noLost++;
                }
                else
                {
                    balance += item.Win();
                }
            }
            Console.WriteLine(balance);
            Console.ReadLine();
            //int totalGain = contests.Sum(x => x.Luck), totalLoss = 0, importantLosses = 0, max =0;


            //for (int i = 0; i < important.Count(); i++)
            //{                
            //    //get those with the lowest luck value                
            //    //loose as many of them within the allowed limit
            //    Contest c = important.ElementAt(i);
            //    while (importantLosses < maxNoOfImportantLosses)
            //    {                    
            //        totalLoss += c.Luck;
            //        //totalGain = contests.Where(x=>x.)
            //        if ((totalGain - totalLoss) > max)
            //        {
            //            max = totalGain - totalLoss;
            //        }                   
            //            importantLosses++;

            //    }                
        }
        
    }

    public class Contest
    {
        public int Luck { get; set; }
        public int Rating { get; set; }

        public int Lose()
        {
            return Luck;
        }

        public int Win()
        {
            return -Luck;
        }
    }
}

