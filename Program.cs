using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Test
{
    class Program
    {
        static int Main1(string[] args)
        {
            int[] arr = new int[5] { 2, 4, 6, 8, 9 };
            Console.WriteLine("Enter number");
            int key_value = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if(key_value == arr[i])
                {
                    Console.WriteLine("Number available");
                    return 1;
                }                              
            }

            Console.WriteLine("Number not available");
            Console.ReadKey();
            return 0;            
        }
    }
}
