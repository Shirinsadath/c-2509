using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignment_1
{
    public class Print
    {
        public void ToPrint(string Name)

        {
            Console.WriteLine(Name);
        }
        public void ToPrint(int Number)
        {
            Console.WriteLine(Number);
        }
        public void ToPrint(int[] array)
        {
            Console.WriteLine("array : ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "  ");
            }
        }
    }
}

//===========================================
