using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_calculator
{
     class calc
    {
        public static double addition(double a, double b)// метод для сложения чисел
        { 
            return  a + b;
        }
        public static double multiplication(double a, double b)// метод для умнажения числе
        { 
            return a * b;
        }
        
        public static void division(double a, double b, ref double c, out bool check)// метод деления с проверкой условия деления
        {
            if (b != 0)
            {
                c = a / b;
                check = true;
            }
            else
            {
                
                check = false;
            }
        }
        public static double subtraction(double a, double b)// метод вычитания чисел
        { 
            return a - b;
        }
    }
}
