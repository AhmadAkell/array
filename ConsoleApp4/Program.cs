using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[6];
            number[0] = 1;
            number[1] = 2;
            number[2] = 3;
            number[3] = 4;
            number[4] = 5;
            number[5] = 6;
            for (int i = 0; i < number.Length ; i++)
            {
                Console.WriteLine("the result is :" +number [i]+1 );
            }
            Console.ReadKey();
        }
    }
}
