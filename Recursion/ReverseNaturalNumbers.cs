using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Test.Recursion
{
    class ReverseNaturalNumbers
    {
        static void Main2()
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int count = 1;
            int res = ReverseCount(count, num);
            Console.ReadKey();
        }

        private static int ReverseCount(int count, int num)
        {
            if (count > num)
            {
                return -1;
            }

            Console.WriteLine(num);
            return ReverseCount(count, num - 1);
        }
    }
}
