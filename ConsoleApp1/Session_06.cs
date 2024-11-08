using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Session_06
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            //NhapMangBangCom(a);
            InMang(a);
            InMangNgauNhien(a);
            IncreaseItems(a, 10);
            InMang(a);
        }
        
        static void NhapMangBangCom(int[]a)
        {

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Nhap phan tu thu #{i}: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        static void InMangNgauNhien(int[] a)
        {
            Random random = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(100);  
            }


            static void InMang(int[]a)
        {
            Console.WriteLine("Array contents: ");
            foreach (int item in a)
            {
            Console.Write($"{item}, "); 
            }
              Console.WriteLine();
        }

        static void IncreaseItems(int[]a, int val)
        { 
            for (int i = 0; i < a.Length; i++)
                a[i] += val;
        }
    }


}
