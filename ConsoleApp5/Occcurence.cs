using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Occcurence
    {
        public static void Main(string[] args)
        {
            {
                int[] num = new int[5] { 1, 2, 3, 4, 5 };
                int n = 1;
                int count = 0;

                for (int i = 0; i < num.Length; i++)
                {
                    if (num[i]==n)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"the number{n} appers {count } times");

            }
        }
    }
}


