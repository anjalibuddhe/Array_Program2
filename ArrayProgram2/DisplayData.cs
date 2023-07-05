using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//7.	WAP to create a list using ArrayList. Iterate over collections to display data

namespace ArrayProgram2
{
    internal class DisplayData
    {
        static void Main(string[] args)
        {
            ArrayList emp = new ArrayList();

            emp.Add("Id");
            emp.Add(101);
            emp.Add("name");
            emp.Add("hari");

            for (int i = 0; i < emp.Count; i++)
            {
                Console.WriteLine(emp[i]);
            }


        }
    }
}
