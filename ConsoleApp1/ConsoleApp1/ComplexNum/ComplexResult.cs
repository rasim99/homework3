using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ComplexNum
{
    public class ComplexResult
    {


        public int Sumresult()
        {
            int[] Numb = { 1, 2, 3, 4, 5, 6, 7, 9 };
            int sum = 0;
            int reslt = 1;
            for (int i = 0; i < Numb.Length; i++)
            {
                int Z = Numb[i];
                if (Z % 2 == 0)
                {
                    sum += Z;
                    reslt = sum * sum;
                }
            }
            return Console.WriteLine(reslt);
        }
    }
}
