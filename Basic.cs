using System;
using Console_calculator;

namespace Console_calculator
{
    class Basic
    {
       
        static void Main()
        {
            bool trey = true;
            while (trey)
            {
                Console.WriteLine("Enter the operation number!\n To perform addition, enter +\n To perform subtraction, enter -\n To perform multiplication, enter *\n To perform division, enter /\n For exit enter: exit");// выводим основную информацию о программе
                string value = Console.ReadLine()!;// получаем команду на выполнения нужной операции
                Print.PrintSub(value);// последующие 4 выполняют нужные нам операции в зависимости от того какую операцию мы выбрали
                Print.PrintMult(value);
                Print.PrintDivi(value);
                Print.PrintAdd(value);
                trey = Print.PrintExit(value);// проверет условия выхода из программы
            }
        }
    }
}
