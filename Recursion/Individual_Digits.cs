using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Test.Recursion
{
    class Individual_Digits
    {
        static void Main4()
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            Find(num);
            Console.ReadKey();
        }

        private static void Find(int num)
        {
            if (num < 10)
            {
                Console.Write(num);
                return;
            }
                        
            Find(num / 10);
            int rem = num % 10;
            Console.Write(rem);
        }
    }
}
