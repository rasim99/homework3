using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Result
    {
         public static void Result1()
         {
            int[] Numbers = { 1, 34, 56, 3, 66, 2, 20, 23, 7, 28 };
            int rest = 1;
            for (int i = 0; i <Numbers.Length; i++)
            {
                int T= Numbers[i];
                
                if (T>=1&& T<=20)
                {
                    rest *= T;
                }
            }
            Console.WriteLine(rest);
         }

    }
}
