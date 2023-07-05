using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.	WAP to create an array of 5 integers. Initialize 5 values. Display using foreach loop.

namespace ArrayProgram2
{
    internal class CreateArray
    {
        static void Main(string[] args)
        {
            int[] num =new int[5] { 34,55,26,87,48};
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
        }
    }
}
