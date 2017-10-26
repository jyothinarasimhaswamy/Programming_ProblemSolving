using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Test
{
    class LargeSmLL
    {
        static void Main14()
        {
            int[] arr = new int[6] { 20, 2, 0, 4, 25, 6 };
            int largest = arr[0];
            int smallest = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < smallest)
                    smallest = arr[i];
                else if (arr[i] > largest)
                    largest = arr[i];
            }

            Console.WriteLine("Smallest=" + smallest);
            Console.WriteLine("Largest=" + largest);
            Console.ReadKey();
        }

        
    }
}
