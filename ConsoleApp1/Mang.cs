using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHoangNam_31231026682
{
    internal class Mang
    {
        static void Main(string[] args)
        {
            int[] arr = { 155, -8, 108, 2, 25, 88, 108, 68, 95, 4 };
            //Ex_01(arr);
            //Ex_02(arr);
            Ex_06(arr);
        }

        static void Ex_01(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int a = arr[i];
                sum += arr[i];
            }
            int count = arr.Length;
            int Tb = sum / count;
            Console.WriteLine(sum);
            Console.WriteLine(Tb);
        }

        static void Ex_02(int[] arr)
        {
            Console.Write("Input: ");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == a)
                    Console.WriteLine($"{a} match at the position {i}");
                else
                    Console.WriteLine("Not contain");
                return;
            }
        }

        static void Ex_03(int[] arr)
        {
            Console.Write("Input the element to remove: ");
            int a = int.Parse(Console.ReadLine());
            int indexToRemove = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == a)
                {
                    indexToRemove = i;
                    break;
                }
            }

            if (indexToRemove == -1)
            {
                Console.WriteLine("Element not found in the array.");
                return;
            }
            int[] newArr = new int[arr.Length - 1];
            for (int i = 0; i < indexToRemove; i++)
                newArr[i] = arr[i];
            for (int i = indexToRemove + 1; i < arr.Length; i++)
            {
                newArr[i + 1] = arr[i];
            }
            Console.WriteLine("Updated Array: " + string.Join(", ", newArr));
        }

        static void Ex_04(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
                if (arr[i] > max)
                    max = arr[i];
            }
            Console.WriteLine(min);
            Console.WriteLine(max);
        }

        static void Ex_05(int[] arr)
        {
            int[] arr1 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr1[arr.Length - 1 - i] = arr[i];
            }
            Console.WriteLine(string.Join(", ", arr1));
        }

        static void Ex_06(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine("Duplicate");
                        return;
                    }
                    Console.WriteLine("No duplicate");
                }
            }
        }

        static void Ex_07(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine("Duplicate");
                        return;
                    }
                    Console.WriteLine("No duplicate");
                }
            }
        }
    }
}

