using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Session_04
    {
        static void Main1(string[] args)
        {
            Question_12();
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
            Console.WriteLine("{0} + {1} = {2}", a, b, sum);
            Console.WriteLine("{0} - {1} = {2}", a, b, diff);
            Console.WriteLine("{0} * {1} = {2}", a, b, multi);
            Console.WriteLine("{0} / {1} = {2}", a, b, div);
            Console.WriteLine("{0} % {1} = {2}", a, b, chiaDu);
        }

        static void Question_02()
        {
            Console.Write("Input y: ");
            float y = float.Parse(Console.ReadLine());
            float x = y * y + 2 * y + 1;
            if ((y > 5) || (y < -5))
                Console.WriteLine("y must belongs to [-5;5]");
            else
                Console.WriteLine("The result with y = {0} is {1}", y, x);


        }

        static void Question_03()
        {
            Console.Write("Input distance: ");
            float dis = float.Parse(Console.ReadLine());
            Console.Write("Input hour: ");
            float hour = float.Parse(Console.ReadLine());
            Console.Write("Input minute: ");
            float min = float.Parse(Console.ReadLine());
            Console.Write("Input second: ");
            float sec = float.Parse(Console.ReadLine());
            float quydoi = hour + min / 60 + sec / 3600;
            float speed = dis / quydoi;
            float milesHour = speed / 1.609f;
            Console.WriteLine("Speed is {0}km/h and {1} miles/h", speed, milesHour);

        }

        static void Question_04()
        {
            Console.Write("Input radius: ");
            float r = float.Parse(Console.ReadLine());
            float S = 4 * r * r * 3.1459f;
            float V = 4 / 3 * 3.1459f * r * r * r;
            Console.WriteLine("Surface = {0} and Volume = {1}", S, V);

        }

        static void Question_05()
        {
            Console.Write("Input a character: ");
            char a = char.Parse(Console.ReadLine());
            if (a == 'u' || a == 'e' || a == 'o' || a == 'a' || a == 'i')
                Console.WriteLine("That is a vowel");
            else if (a <= '9' && a >= '0')
                Console.WriteLine("This is a number");
            else 
                Console.WriteLine("This is a symbol");
            Console.ReadKey();

        }
        // Write a C# Sharp program to check whether a given number is even or odd.
        static void Question_06()
        {
            int a = 5;
            int v = a % 2;
            if (v == 0)
            {
                Console.WriteLine("Even");
                
            }
            else
                Console.WriteLine("Odd");

        }
        // Write a C# Sharp program to find the largest of three numbers.
        static void Question_07()
        {
            Console.Write("Input num 1: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Input num 2: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Input num 3: ");
            float c = float.Parse(Console.ReadLine());

            if ((a == b) && (b == c))
                Console.WriteLine("3 so trung nhau");
            else if ((a == b) && (b > c))
                Console.WriteLine("a va b = {0} lon hon {1}", a, c);
            else if ((a == c) && (c > b))
                Console.WriteLine("a va c = {0} lon hon {1}", a, b);
            else if ((a > b) && (a > c))
                Console.WriteLine("a = {0} la so lon nhat",a);
            else if ((b > a) && (b > c))
                Console.WriteLine("b = {0} la so lon nhat",b);
            else if ((c > b) && (c > a))
                Console.WriteLine("c = {0} la so lon nhat",c);
        }

        // Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
        static void Question_08()
        {
            Console.Write("Input x: ");
            float x = float.Parse(Console.ReadLine());
            Console.Write("Input y: ");
            float y = float.Parse(Console.ReadLine());
            if ((x > 0) && (y > 0))
                Console.WriteLine("The coordinate point ({0};{1}) lies in the First quadrant", x, y);
            if ((x < 0) && (y > 0))
                Console.WriteLine("The coordinate point ({0};{1}) lies in the Second quadrant", x, y);
            if ((x < 0) && (y < 0))
                Console.WriteLine("The coordinate point ({0};{1}) lies in the Third quadrant", x, y);
            if ((x > 0) && (y < 0))
                Console.WriteLine("The coordinate point ({0};{1}) lies in the Fourth quadrant", x, y);
        }

        // Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
        static void Question_09()
        {
            Console.Write("Input side 1: ");
            float x = float.Parse(Console.ReadLine());
            Console.Write("Input side 2: ");
            float y = float.Parse(Console.ReadLine());
            Console.Write("Input side 3: ");
            float z = float.Parse(Console.ReadLine());
            if ((x + y >= z) || (x + z >= y) || (y + z >= x))
            {
                Console.WriteLine("This is not a triangle");
                return;
            }
                if ((x == y) && (y == z))
                    Console.WriteLine("This triangle is Equilateral");
                if ((x == y) || (y == z) || (y == z))
                    Console.WriteLine("This triangle is Isosceles");
                else
                    Console.WriteLine("This triangle is Scalene");
                Console.ReadKey();

        }

    
        
        // Write a program to read 10 numbers and find their average and sum.
        
        static void Question_10()
        {
            int sum = 0;
            Console.WriteLine("Input the 10 numbers: ");
            
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Number {i}: ");
                int n = int.Parse(Console.ReadLine());
                sum += n;
            }
            float avg = (float)sum / 10;
            Console.WriteLine($"Sum of 10 input numbers: {sum}");
            Console.ReadKey();
        }

        // Write a program to display the n terms of harmonic series and their sum. 1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n terms



        static void Question_11()
        {
            Console.Write("Enter the number of terms (n) for the harmonic series: ");
            int n = int.Parse(Console.ReadLine());
            float sum = 0;
            for (int i = 1; i <= n; i++)
            {
                float harmonic = 1f / i;
                Console.WriteLine($"1/{i}");
                sum += harmonic;
            }
            Console.WriteLine($"Sum of the harmonic: {sum}");
            Console.ReadKey();
        }

        static void Question_12()
        {
            //Console.Write("Enter min: ");
            //int min = int.Parse(Console.ReadLine());
            //Console.Write("Enter max: ");
            //int max = int.Parse(Console.ReadLine());
            
            
            
            //double x = 2;
            //double z = n;
            //double y = n - 1;
            //double result1 = Math.Pow(x, y);
            //double result2 = Math.Pow(x, z);
            //double b = result1 * (result2 - 1);
            //Console.WriteLine($"{b}");

            //Console.ReadKey();
        }
    }
}
    
