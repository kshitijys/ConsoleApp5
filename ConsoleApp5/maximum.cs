using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class maximum
    {
        static void Main(string[] args)
        {
            {
                int[] num = new int[10] { 1, 2, 3, 4, 5, 9, 6, 8, 7, 3 };

                int i, mx;
                mx = num[0];

                for (i = 0; i < num.Length; i++)
                {
                    if (num[i] > mx)
                    {
                        mx = num[i];
                    }
                }
                Console.Write($"Maximum number is :{mx}");




            }
        }
    }
}

