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
            Console.Write(Str);

            //Получение строки
            string tmpString = Console.ReadLine();

            //Преобразование строки в число
            int tmpArg = Convert.ToInt32(tmpString);

            return tmpArg;
        }

        static void Main(string[] args)
        {
            int a, b, c, max;

            try
            {

                a = GetNumber("Введите число а:");
                b = GetNumber("Введите число b:");
                c = GetNumber("Введите число c:");

                if (a > b)
                {
                    if(a > c)
                    {
                        max = a;
                    }
                else
                {
                    max = c;
                }
                }
                else
                {
                    if(b > c)
                    {
                        max = b;
                    }
                    else
                    {
                        max = c;
                    }
            }
                Console.WriteLine("MAX = " + max);

            }
            catch (SystemException)
            {
                Console.WriteLine("Произошла ошибка, вероятно, были введены некорректные данные!");
            }
        }
    }
}
