using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SessIon_07
    {
        static void Main1(string[] args)
        {
            int[,] a;

            Console.Write("So dong: "); int rows = int.Parse(Console.ReadLine());
            Console.Write("So cot: "); int cols = int.Parse(Console.ReadLine());

            a = new int[rows, cols];

            NhapMangHaiChieuNgauNhien(a);
            XuatMang(a);

            Console.Write("Ban muon in cot thu may: "); int selCol = int.Parse(Console.ReadLine());
            XuatMangColIndex(a, selCol);
            Console.Write("Ban muon in dong thu may: "); int selRow = int.Parse(Console.ReadLine());
            XuatMangRowIndex(a, selRow);
        }



        static void XuatMang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i,j]}\t");
                }
                Console.WriteLine();
            }
        }

        static void NhapMangHaiChieuNgauNhien(int[,] a)
        {
            Random random = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = random.Next(100);
                }
            }
        }

        static void XuatMangColIndex(int[,] a, int ColIndex)
        {
            if (ColIndex < 0 || ColIndex > a.GetLength(1) - 1)
                Console.WriteLine("Sai");
            else
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    Console.Write($"{a[i, ColIndex]}\t");
                }
            }
            Console.WriteLine();
        }


        static void XuatMangRowIndex(int[,] a, int RowIndex)
        {
            if (RowIndex < 0 || RowIndex > a.GetLength(0) - 1)
                Console.WriteLine("Sai");
            else
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[RowIndex, j]}\t");
                }
            }

        }

    }
}
