using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Test.Recursion
{
    class NaturalNumbers
    {
        static void Main1()
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            int count = 1;
            int res = CallRecursion(count, num);
            Console.ReadKey();
        }

        private static int CallRecursion(int count, int num)
        {
            if (count <= num)
            {
                Console.WriteLine(count);
                CallRecursion(count + 1, num);
            }

            return -1;

        }
    }
}
