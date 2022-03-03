using System;

namespace HW_1_3
{
    internal class BranchStructuries
    {
        /* Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, 
         * если A=B, подсчитать A*B, если A<B, подсчитать A-B.*/
        public static int FindSumOrDifferenceOrProduct(int a, int b)
        {
            if (a > b)
            {
                return (a + b);
            }
            else if (a == b)
            {
                return (a * b);
            }
            else
            {
                return (a - b);
            }
        }




    }
}
