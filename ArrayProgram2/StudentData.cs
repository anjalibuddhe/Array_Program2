using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2.WAP to create an array of 5 strings to store students name, sort names in ascending order & display using foreach loop.
namespace ArrayProgram2
{
    internal class StudentData
    {
        static void Main(string[] args)
        {
            string[] name = new string[] { "Hari","Sita","Gita","John","Sara","Aaliya" };

            Array.Sort(name);

            foreach (var sname in name)
            {
                Console.WriteLine(sname);
            }

        }
    }
}
