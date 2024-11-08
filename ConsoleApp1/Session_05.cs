using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Session_05
    {
        static void Main()
        {
            Question_01();
        }

        static void Question_01()
        {
            Console.Write("Input num a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input num b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Input num c: ");
            int c = int.Parse(Console.ReadLine());
            if ((a > b) && (a > c))
                Console.WriteLine($"{a}");
            else if ((b > c) && (b > a))
                Console.WriteLine($"{b}");
            else Console.WriteLine($"{c}");
        }

        static void Question_02()
        {
            Console.Write("Input num a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input num b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Input num c: ");
            int c = int.Parse(Console.ReadLine());
            if ((a > b) && (a > c))
                Console.WriteLine($"{a}");
            else if ((b > c) && (b > a))
                Console.WriteLine($"{b}");
            else Console.WriteLine($"{c}");
        }


    }

}
