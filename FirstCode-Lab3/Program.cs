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
        static int GetNumber(string str)
        {
            Console.Write("Введите число " + str + ":");

            string tmpString = Console.ReadLine();
            int exit = 0;
            int tmpArg;
            
            if(int.TryParse(tmpString, out tmpArg))
            {
                return tmpArg;
            }
            else
            {
                Console.WriteLine("Введено не корректное значение. Значение по умотчанию " + exit + ".");
                return exit;
            }            
        }
        
        static void Main(string[] args)
        {
            int a, b, c, max;

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

            Console.ReadKey();
        }
    }
}
