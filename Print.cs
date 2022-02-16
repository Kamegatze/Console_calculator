using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_calculator
{
     class Print
    {
        public static void PrintAdd(string value)// метод выполняется если значение совпадает с "+"
        {
            if (value == "+")
            {
                Console.WriteLine("Enter value a");
                double a = Double.Parse(Console.ReadLine()!);
                Console.WriteLine("Enter value b");
                double b = Double.Parse(Console.ReadLine()!);
                Console.WriteLine($"{a} + {b} = {calc.addition(a, b)}");
                Console.ReadKey();
            }
        }
        public static void PrintSub(string value)// метод выполняется если значение совпадает с "-"
        {
            if (value == "-")
            {
                Console.WriteLine("Enter value a");
                double a = Double.Parse(Console.ReadLine()!);
                Console.WriteLine("Enter value b");
                double b = Double.Parse(Console.ReadLine()!);
                Console.WriteLine($"{a} - {b} = {calc.subtraction(a, b)}");
                Console.ReadKey();
            }
        }
        public static void PrintMult(string value)// метод выполняется если значение совпадает с "*"
        {
            if (value == "*")
            {
                Console.WriteLine("Enter value a");
                double a = Double.Parse(Console.ReadLine()!);
                Console.WriteLine("Enter value b");
                double b = Double.Parse(Console.ReadLine()!);
                Console.WriteLine($"{a} * {b} = {calc.multiplication(a, b)}");
                Console.ReadKey();
            }
        }
        public static void PrintDivi(string value)// метод выполняется если значение совпадает с "/"
        {
            if (value == "/")
            {
                Console.WriteLine("Enter value a");
                double a = Double.Parse(Console.ReadLine()!);
                Console.WriteLine("Enter value b");
                double b = Double.Parse(Console.ReadLine()!);
                double c = 0;
                bool check;
                calc.division(a, b, ref c, out check);
                if (check)
                    Console.WriteLine($"{a} / {b} = {c}");
                else
                    Console.WriteLine("Division on null impossibble!!!");
                Console.ReadKey();
            }
        }
        public static bool PrintExit(string value)// проверка на выход из консоли
        {
            if (value == "exit")
                return false;
            else
                return true;

        }
    }
}
