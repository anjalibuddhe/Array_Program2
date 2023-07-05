using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5.	WAP to store rain fall in a week using 1D array , accept & display the rain fall.

namespace ArrayProgram2
{
    internal class RainFall
    {
        static void Main(string[] args)
        {
            double[] week = new double[7];


            Console.WriteLine("Accept rain fall");
            for (int i = 0; i <week.Length; i++)
            {
                week[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i <week.Length; i++)
            {
                Console.Write(week[i] + "\t");
            }
            Console.WriteLine();
        }
    }
}
