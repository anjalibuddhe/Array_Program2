using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgram2
{
    internal class DemoProgram
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)

            {
                if(i%3 == 0 && i%5 == 0){
                    Console.WriteLine("OneXTel");
                }

                else if (i%3 == 0)
                {
                    Console.WriteLine("OneX");
                }
                else if(i%5 == 0) {
                    Console.WriteLine("Tel");
                }
                else
                {
                    Console.WriteLine(i);
                }
                
               
            }
            Console.WriteLine();
        }
    }
}
