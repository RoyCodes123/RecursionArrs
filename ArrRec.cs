using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static void PrintArr(int[] arr, int len)
        {
            if (len == 1)
                Console.Write(arr[len - 1] + " ");
            else
            {
                PrintArr(arr, len - 1);
                Console.Write(arr[len - 1] + " ");
            }
        }

        static int SumArr(int[] arr, int len)
        {
            if (len == 1)
                return arr[len - 1];
            else
                return SumArr(arr, len - 1) + arr[len - 1];
        }

        static int MaxArr(int[] arr, int len)
        {
            if (len == 1)
                return arr[len - 1];
            else
                return Math.Max(MaxArr(arr, len - 1) , arr[len - 1]);
        }


        static int ZeroArr(int[] arr, int len)
        {
            if (len == 1)
            {
                if (arr[len - 1] == 0)
                    return 1;
                else
                    return 0;
            }

            else if (arr[len - 1] == 0)
                    return ZeroArr(arr, len - 1) + 1;
                else
                    return ZeroArr(arr, len - 1);
        }

        static int DigitNum(int n) 
        {
            if (n < 10)
                return 1;
            else
                return 1 + DigitNum(n / 10);
        }

        static int ThreeArr(int[] arr, int len)
        {
            if (len == 1)
            {
                if (DigitNum(arr[len - 1]) == 3)
                    return 1;
                else
                    return 0;
            }

            else if (DigitNum(arr[len - 1]) == 3)
                return ThreeArr(arr, len - 1) + 1;
            else
                return ThreeArr(arr, len - 1);
        }


        static int SumSeven(int[] arr, int len)
        {
            if (len == 1)
            {
                if ((arr[len - 1]/10)%10 == 7)
                    return arr[len - 1];
                else
                    return 0;
            }
            else if ((arr[len - 1] / 10) % 10 == 7)
                return SumSeven(arr, len - 1) + arr[len - 1];
            else
                return SumSeven(arr, len - 1);
        }

        static void MinMax(int[] arr, int left, int right, int[] min, int[] max)
        {
            if (left == right)
            {
                min[0] = arr[left];
                max[0] = arr[left];
            }
            else
            {
                min[0]=Math.Min(
            }

        }

        static void Arr(int[] arr)
        {
            arr[0] = 1;
        }
        static void Main(string[] args)
        {
            int[] arr={771,72,99,0};
            Arr(arr);
            Console.WriteLine(arr[0]);
        }
    }
}
