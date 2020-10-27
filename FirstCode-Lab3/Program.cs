using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCode_Lab3
{
    class Program
    {
        /*
    * Данный метод выводит пользователю приглашение,
    * указанное в аргументе anOutputStr, получает введенную
    * с клавиатуры строку, преобразует её в целое число и
    * возвращает это число
    */
        static int GetNumber(string Str)
        {
            //Вывод приглашения пользователю
            Console.Write("Введите число " + Str + ":");

            string tmpString = Console.ReadLine();

            int tmpArg = Convert.ToInt32(tmpString);

            return tmpArg;
        }

        static void Main(string[] args)
        {
            int a, b, c, max;

            try
            {
                a = GetNumber("а");
                b = GetNumber("b");
                c = GetNumber("c");

                if (a > b)
                {
                    max = (a > c) ? a : c;
                }
                else
                {
                    max = (b > c) ? b : c;
                }
                Console.WriteLine("MAX = " + max);
            }
            catch (SystemException ex)
            {
                Console.WriteLine("Произошла ошибка, вероятно, были введены некорректные данные!");
                Console.WriteLine("Причина ошибки: " + ex.Message);
            }
            Console.ReadKey();
        }

    }
}
