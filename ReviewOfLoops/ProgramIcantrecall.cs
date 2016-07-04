using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewOfLoops
{
    public class ProgramIcantrecall
    {
        public static void Main1(string[] args)
        {
            //ArrayList al = new ArrayList();
            //Array.BinarySearch(Array.Sort()
            List<List<int>> seqList = new List<List<int>>();
            int listSize = -1, lastAns = 0, noOfQueries =-1;
            string[] line1 = Console.ReadLine().Split(' ');
            if(line1!=null && line1.Length==2)
            {
                int.TryParse(line1[0], out listSize);
                int.TryParse(line1[1], out noOfQueries);
            }
          if(line1==null)
          {
              //Console.WriteLine("line1 = null");
          }
          else
          {
              //Console.WriteLine("line1 length = " + line1.Length);
          }
                
          if (listSize < 1 || listSize > 100000) 
          {
              //Console.WriteLine("Listsize = " + listSize);
              return;
          }
            if (noOfQueries < 1 || noOfQueries > 100000) 
            {
              //Console.WriteLine("noOfQueries = " + noOfQueries);
              return;
          }
            for(int i=0; i<listSize; i++)
            {
                seqList.Add(new List<int>());
            }
           //Console.WriteLine(seqList.Count);
            for(int j=0; j<noOfQueries; j++)
            {
                string[] input = Console.ReadLine().Split(' ');
                if(input != null && input.Length>2)
                {
                    int x = 0, y = 0, queryType = 0;
                    int.TryParse(input[0], out queryType);
                    int.TryParse(input[1], out x);                        
                    int.TryParse(input[2], out y);    
                    //Console.WriteLine(String.Format("X= {0} y= {1} QueryType= {2}", x, y, queryType));

                    if (x < 0 || x > 1000000000) return;
                    if (y < 0 || y > 1000000000) return;

                    if(queryType==1)
                    {                        
                        //do query 1
                        int index = GetIndex(x, lastAns, listSize);
                        int counter = 0;
                        foreach (var list in seqList)//get the list we want
                        {
                            if (counter == index)
                            {
                                //Console.WriteLine(String.Format("Added y({2}) to Position {0} in List{1} y= {2}", index, counter, y));
                                list.Add(y);
                                break;
                            }
                            counter++;
                        }
                    }
                    if(queryType==2)
                    {
                        //Console.WriteLine("Query 2 Outer loop");
                        int index = GetIndex(x, lastAns, listSize);
                        int counter = 0, innerListCounter=0;
                        foreach (var list in seqList)
                        {
                            //Console.WriteLine(String.Format("Counter = {0}, index = {1}", counter, index));
                            if (counter == index)
                            {
                                if(list.Count==0)break;
                                int targetIndex = y % list.Count;
                                //Console.WriteLine(String.Format("The index to locate in list {0} is {1}!", index, target));
                                //var x = list.ToArray()[targetIndex];
                                foreach (var item in list)
                                {                                       
                                    if (innerListCounter == targetIndex) //this element matches target
                                    {
                                        //int formerVal = lastAns;
                                        lastAns = item;
                                        //Console.WriteLine(String.Format("Last ans was = {0}",formerVal));
                                        Console.WriteLine(lastAns);
                                    }
                                    innerListCounter++;
                                }
                                break;
                            }
                            counter++;
                        }
                    }
                }
            }
            
        }

        static int GetIndex(int x, int lastAns, int listSize)
        {
            int y = (x ^ lastAns) % listSize;
            //Console.WriteLine("Getting Index where x = {0} lastAns = {1} listSize = {2}", x, lastAns, listSize);
            return y;
        }
    }
}

