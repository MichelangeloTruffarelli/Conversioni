using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 0;
            value = Convert.ToInt32(Console.ReadLine());
            string binary = Convert.ToString(value, 2);
            Console.WriteLine(binary);
            Console.ReadLine();
        }
    }
}
