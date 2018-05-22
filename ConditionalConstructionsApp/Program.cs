using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalConstructionsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // условные конструкции if...else, switch...case
            int num1 = 8;
            int num2 = 16;

            if (num1 > num2 && num1==8)
            {
                Console.WriteLine("num1 больше чем num2");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"{num1} меньше {num2}");
            }
            else
            {
                Console.WriteLine($"{num1} равно {num2}");
            }

            Console.WriteLine("Нажмите Y или N");
            string selection = Console.ReadLine();
            // операторы перехода break, goto case, return, throw
            switch(selection)
            {
                case "Y":
                    Console.WriteLine("Вы нажали клавишу Y");
                    break;  // или goto case "N"; - переход на выполнение блока кода клавишы N
                                     // или return; - выход из программы
                                     // или throw; - тип ошибки сгенериовать
                case "N":
                    Console.WriteLine("Вы нажали клавишу N");
                    break;
                default:
                    Console.WriteLine("Вы нажали неизвестную клавишу");
                    break;
            }

            // Тернарный оператор - требует наличие 3-х операндов ор1?ор:ор3;
            int x = 3;
            int y = 2;
            Console.WriteLine("Нажмите + или -");
            string selection2 = Console.ReadLine();

            int z = selection2 == "+" ? (x + y) : (x - y);
            Console.WriteLine(z);

            Console.ReadKey();
        }
    }
}
