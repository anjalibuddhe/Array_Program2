using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//4.WAP to create jagged array, initialized data & display the details
namespace ArrayProgram2
{
    internal class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] jarray = new int[4][];

            jarray[0] = new int[3] { 7, 9,4 };
            jarray[1] = new int[2] {42, 26 };
            jarray[2] = new int[5] { 5, 7, 9, 11, 1 };
            jarray[3] = new int[4] { 4, 6, 8,1 };

            
            for(int i = 0; i < jarray.Length; i++)
            {
                for (int j = 0; j < jarray[i].Length; j++)
                {
                    Console.Write( jarray[i][j] +" \t");
                }
                Console.WriteLine();
            }


            string[][] jarray2 = new string[2][];

            jarray2[0] = new string[2] { "mobile", "laptop"};
            jarray2[1] = new string[2] { "samsung","Hp"};

            for (int i = 0; i < jarray2.Length; i++)
            {
                for (int j = 0; j < jarray2.Length; j++)
                {
                    Console.Write(jarray2[i][j]+"\t");
                }
                Console.WriteLine();
            }
            {

            }
        }
    }
}