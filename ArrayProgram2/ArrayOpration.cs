using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//6.	WAP to accept an array of 5 integers. Perform Sort(), Reverse(), Copy(), Clear() operations.

namespace ArrayProgram2
{
    internal class ArrayOpration
    {
        static void Main(string[] args)
        {
            int[] num = new int[5] {3,6,2,8,1};

            Console.WriteLine("----sort method-----------");
            Array.Sort(num);
            foreach (int i in num)
            {
                Console.WriteLine(i);

            }

            Console.WriteLine("--------Reverse------------");

            int[] temp = num;

            Array.Reverse(temp);
            foreach (int i in temp)
            {
                Console.WriteLine(i +" ");
            }

            Console.WriteLine("-----------Copy----------");
            int[] c = new int[5] { 1, 2, 3, 4, 5 };
            Array.Copy(num, 2, c, 2, 2);
            foreach (var item in c)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------Clear-------------");
            Array.Clear(c, 1, 3);
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write("{0} ", c[i]);
            }
        }
    }
}
