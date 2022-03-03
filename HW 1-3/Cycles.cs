using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1_3
{
    internal class Cycles
    {
        /* 1. Пользователь вводит 2 числа (A и B). Возвести число A в степень B.*/
        public static int Exponentiate(int a, int b)
        {
            int tmp = 1;
            while (b != 0)
            {
                tmp = tmp * a;
                b--;
            }
            return tmp;
        }



    }
}
