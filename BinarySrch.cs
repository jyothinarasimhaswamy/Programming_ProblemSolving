using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Test
{
    class BinarySrch
    {
        static void Main11()
        {
            int[] arr = new int[10] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            
            Console.WriteLine("Enter the number");
            int srch_key = int.Parse(Console.ReadLine());

            int result = BinarySearch(arr, arr.Length, srch_key);
            if (result != -1)
                Console.WriteLine("Number=" + result);
            else
                Console.WriteLine("Not found");
            Console.ReadKey();
        }

        private static int BinarySearch(int[] arr, int length, int srch_key)
        {
            int start = 0;
            int end = length - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (srch_key == arr[mid])
                    return mid;
                else if (srch_key < arr[mid])
                {
                    end = mid - 1;
                }
                else
                    start = mid + 1;
            }

            return -1;
        }
    }
}

