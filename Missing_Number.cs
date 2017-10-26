using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Test
{
    class Missing_Number
    {
        static void Main12(string[] args)
        {
            int[] arr = new int[5] { 1, 2, 4, 5, 6 };
            int limit = 5;
            bool val = false;
            for (int i = 1; i <= limit; i++)
            {
                val = true;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i == arr[j])
                    {
                        val = false;
                    }
                }
                if (val == true)
                {
                    Console.WriteLine("Number not found=" + i);
                    break;
                }
            }

            Console.ReadKey();

        }
    }
}
