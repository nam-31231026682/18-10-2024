using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace ConsoleApp1
{
    internal class Session_06
    {
        static void Main1()
        {
            int[] array = { 29, 82, 54, 66, 23, 44, 78, 11, 33 };
            //BubbleSort(array);
            SelectionSort(array);
            Console.WriteLine(string.Join(", ", array));

        }


        static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        //static void SelectionSort(int[] array)
        //{
        //    //tìm nhỏ nhất trong chuỗi rồi đẩy lên ngoài cùng bên trái
        //    int n = array.Length;
        //    for (int i = 0; i < n - 1; i++)
        //    {
        //        int index = i;
        //        int min = array[i];
        //        for (int j = i + 1; j < n; j++)
        //        {
        //            if (array[j] < array[index])
        //            {
        //                index = j;
        //                min = array[j];
        //            }
        //        }
        //        int temp = array[index];
        //        array[index] = array[i];
        //        array[i] = temp;
        //    }
        //}


        static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = array[i];
                for (int j = i + 1; j < i; j++)
                {
                    if (array[j] < array[i])
                    {
                        min = array[j];
                    }

                }
            }
        }
    }
}

        
