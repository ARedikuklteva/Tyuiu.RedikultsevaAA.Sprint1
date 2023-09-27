using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RedikultsevaAA.Sprint1.Task6.V12.Lib;

// Написать программу: пользователь вводит текст.
// Проверить, что последнее слово строки входит в нее еще раз.

namespace Tyuiu.RedikultsevaAA.Sprint1.Task6.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Редикульцева А.А. | АСОиУб 23-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #1                                                                  *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                           *");
            Console.WriteLine("* Задание #6                                                                 *");
            Console.WriteLine("* Вариант #12                                                                *");
            Console.WriteLine("* Выполнила: Редикульцева А.А. | АСОиУб 23-1                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что последнее    *");
            Console.WriteLine("* слово строки входит в нее еще раз.                                         *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            string x;

            Console.WriteLine("Введите строку:");
            x = Convert.ToString(Console.ReadLine());


            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Boolean res = ds.CheckLastWordRepetiton(x);
            if (res == true)
            {
                Console.WriteLine("Последнее слово входит в сторку еще раз");
            }
            else
            {
                Console.WriteLine("Последнее слово НЕ входит в сторку еще раз");
            }


            Console.ReadKey();
        }
    }
}
