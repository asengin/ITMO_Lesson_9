using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор\nВведите 2 целых числа X и Y:");
            try
            {
                Console.Write("X=");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Y=");
                int y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Для выполнения действия, введите:\n" +
                    "1 - Сложить X+Y\n" +
                    "2 - Вычесть X-Y\n" +
                    "3 - Умножить X*Y\n" +
                    "4 - Разделить X/Y");
                sbyte change = Convert.ToSByte(Console.ReadLine());
                switch (change)
                {
                    case 1:
                        {
                            Console.WriteLine($"Результат: {x+y}");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"Результат: {x-y}");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"Результат: {x*y}");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine($"Результат: {x/y}");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Введено неверное значение действия");
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
