using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Test
{
    class SumofNos
    {
        static void Main()
        {
            int[] arr = new int[5] { 2, 3, 4, 5, 6 };
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length ; j++)
                {
                    if(i!=j && arr[i] + arr[j] == num)                   
                        Console.WriteLine(arr[i]+ " " + arr[j]);              
                                        
                }
            }

            Console.ReadKey();
        }
    }
}
