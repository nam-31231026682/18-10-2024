using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Session_03
    {
        public static void Main()
        {
            Question_03();
        }

        static void Question_01()
        {
            Console.Write("Nhap nhiet do C can doi: ");
            float c = float.Parse(Console.ReadLine());
            float k = c + 273;
            float f = c * 18 / 10 + 32;
            Console.WriteLine("{0} do C = {1} do K = {2} do f", c, k, f);
            Console.ReadKey();
        }

        static void Question_02()
        {
            Console.Write("Input radius: ");
            float r = float.Parse(Console.ReadLine());
            double s = 4 * 3.1406 * r;
            double f = 4 / 3 * 3.1406 * r;
            Console.WriteLine("Hinh cau co ban kinh {0} co surface la {1} co volume la {2} ", r, s, f);
            Console.ReadKey();
        }

        static void Question_03()
        {
            Console.Write("Input number 1: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Input number 2: ");
            float num2 = float.Parse(Console.ReadLine());
            float sum = num1 + num2;
            float substract = num1 - num2;
            float multi = num1 * num2;
            float divide = num1 / num2;
            Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, substract);
            Console.WriteLine("{0} * {1} = {2}", num1, num2, multi);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, substract);
            Console.ReadKey();
        }
    }
}