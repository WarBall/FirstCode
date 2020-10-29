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

            int tmpString;
            bool exit; 
            do
            {
                exit = int.TryParse(Console.ReadLine(), out tmpString);
                if (exit == false) 
                    Console.WriteLine("Не корректное значение! Повторите ввод числа " + str + ":");
            }
            while (exit == false); 

            return tmpString;    
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
