using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Session_04
    {
        static void Main(string[] args) 
        {
            Question_04();
        }

        static void Question_01()
        {
            int a = 12; int b = 5;
            int sum = a + b;
            int diff = a - b;
            int multi = a * b;
            int div = a / b;
            int chiaDu = a % b;
            Console.WriteLine("a = 12, b = 5");
            Console.WriteLine("{0} + {1} = {2}",a,b,sum);
            Console.WriteLine("{0} - {1} = {2}", a, b, diff);
            Console.WriteLine("{0} * {1} = {2}", a, b, multi);
            Console.WriteLine("{0} / {1} = {2}", a, b, div);
            Console.WriteLine("{0} % {1} = {2}", a, b, chiaDu);
        }

        static void Question_02()
        {
            int y = -3;
            int pt = y * y + 2 * y + 1;
            Console.WriteLine("The result with y = {0} is {1}", y, pt);
            Console.ReadLine();
            
        }

        static void Question_03()
        {
            float disKm = 36.27f;
            float time = 3.4f;
            float disMile = disKm * 0.621f;
            float speedKm = disKm / time;
            float speedMile = disMile / time;
            Console.WriteLine("{0}km go in {1} hour needs the speed: {2}km/h or {3}miles/h", disKm, time, speedKm,speedMile);

        }

        static void Question_04()
        {
            float r = 23.43f;
            float S = 4 * r * r * 3.1459f;
            float V = 4 / 3 * 3.1459f * r * r * r;
            Console.WriteLine("Surface = {0} and Volume = {1}", S, V);

        }

        static void Question_05()
        {
            string a = "Cai gi vay";
            if (a == "1234")
            {
                Console.WriteLine("Chuan cmnr");
                Console.WriteLine("Gud job bro");
            }
            else
                Console.WriteLine("Nope");

        }
    }
}
