using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Test.Recursion
{
    class Count_Digits
    {
        static void Main5()
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int cnt = 0;

            int res = Count(num, cnt);
            Console.WriteLine(res);
            Console.ReadKey();
        }

        private static int Count(int num, int cnt)
        {

            if (num <= 0)           
             return cnt;          
                        
            return Count(num / 10, ++cnt);

        }
    }
}
