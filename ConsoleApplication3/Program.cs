using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"Taha","Motahareh","Mahyar"};

            for (int i = 0; i < 3; i++) {
                Console.WriteLine(names[i]);
            }
            Console.ReadKey();
        }
    }
}
