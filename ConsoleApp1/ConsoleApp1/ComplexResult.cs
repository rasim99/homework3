using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ComplexResult
    {
        public static int SumResult()
        {
            int[] Numb = { 1, 2, 3, 4, 5, 6, 7 };
            int sum = 0;
            int rest = 1;
            for (int i = 0; i < Numb.Length; i++)
            {
                int Z = Numb[i];
                if (Z%2==0)
                {
                    sum += Z;
                    rest = sum * sum;
                }
            }
            Console.WriteLine(rest);
            return rest;
        }
    }
}
