using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Test.Recursion
{
    class SumNaturalNumbers
    {
        static void Main3()
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            int count = 1;
            int total = 0;
            int res = sum(count, num, total);
            Console.ReadKey();
        }

        private static int sum(int count, int num, int total)
        {
            if (count <= num)
            {
                total = total + count;
                //Console.WriteLine(total);
                sum(count + 1, num, total);
            }

            return -1;
        }
    }
}
