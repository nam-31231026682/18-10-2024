using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Session_05
    {
        static void Main1()
        {
            Question_07();

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
            Console.Write("Input number: ");
            int a = int.Parse(Console.ReadLine());
            int multi = 1;
            if (a <= 0)
            {
                Console.WriteLine("Number must > 0");
            }
            else
            {
                for (int i = 1; i <= a; i++)
                {
                    multi *= i;
                }
                Console.WriteLine($"{multi}");
            }

            //Takes a number as a parameter and checks whether the number is prime or not
        }

        static void Question_03()
        {
            Console.Write("Input positive number: ");
            int a = int.Parse(Console.ReadLine());
            if ((a == 1) || (a == 0))
            {
                Console.WriteLine("Not a prime");
                return;
            }
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    Console.WriteLine("Not Prime");
                    return;
                }
            }
            Console.WriteLine("Prime");

        }


        //to print all prime numbers that less than a number
        static void Question_04()
        {
            Console.Write("Input positive number: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i < n; i++)
            {
                if (PrimeCheck(i))
                {
                    Console.Write(i + " ");
                }
            }
        }
        static bool PrimeCheck(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        //the first N prime numbers
        static void Question_05()
        {
            Console.Write("Input number: ");
            int a = int.Parse(Console.ReadLine());
            int count = 0;
                for (int i = 2; i > 0; i++)
                {
                
                if ((PrimeCheck(i)) && (count < a))
                    {
                    count++;
                    Console.Write(i + " ");
                    }
                }
            
            static bool PrimeCheck(int n)
            {
                if (n <= 1)
                {
                    return false;
                }
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        
        // check whether a number is "Perfect". Then print all perfect number that less than 1000
        static void Question_06()
        {
            for (int n = 2; n <= 999; n++)
            {
                int tong = 0;
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        tong += i;
                    }
                }
                    if (tong == n)
                    {
                        Console.Write(tong + " ");
                    }
            }
        }
        
        //static void Question_07()
        //{
        //    static bool pangramCheck(string str)
        //    {
        //        bool[] alphabet = new bool[26];  // gán a = 0, b = 1,..., z = 25 và mặc định 0
        //        int index = 0;
        //        for (int i = 0; i < str.Length; i++)
        //        {
        //            if ('a' <= str[i] && str[i] <= 'z')
        //                index = str[i] /*- 'a'*/;
        //            else if ('A' <= str[i] && str[i] <= 'Z')
        //                index = str[i] /*- 'A'*/;
        //            else
        //                continue; 
        //            alphabet[index] = true; //sets the corresponding index
        //                                    //in the array to true: if 'b' or 'B' is found,
        //                                    //alphabet[1] will be set to true.
        //        }

        //        for (int i = 0; i <= 25; i++)
        //        {  
        //            if (alphabet[i] == false)
        //                return false;    
        //        }
        //        return true;
        //    }
        //    Console.Write("Input: ");
        //    string str = Console.ReadLine();
        //    if (pangramCheck(str) == true)
        //        Console.Write("Pangram");
        //    else
        //        Console.Write("Not Pangram");
        //}


        static void Question_07()
        {
            static bool pangramCheck(string str)
            {
                bool[] alphabet = new bool[26];
                int charNum = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if ('a' <= str[i] && str[i] <= 'z')
                    {
                        charNum = str[i] - 'a';
                    }
                    else if ('A' <= str[i] && str[i] <= 'Z')
                    {
                        charNum = str[i] - 'A';
                    }
                    else
                        continue;
                    alphabet[charNum] = true;
                }
                for (int i = 0; i <= 25; i++)
                {
                    if (alphabet[i] == false) 
                    {
                        return false;
                    }
                }
                return true; //loop through all character of the string
                             // before returning true
            }
            Console.Write("Input string: ");
                string str = Console.ReadLine();
            if (pangramCheck(str) == false)
            {
                Console.WriteLine("Not pan");
            }
            else
            {
                Console.WriteLine("Pan");
            }
        }
    }
}






    


