using System;
using System.ComponentModel.Design;
using System.Xml.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sbey();
        }
        static void Sbey()                                                 // Функция для получения месяца путём ввода числа
        {
            Console.WriteLine("Введите день недели", "(1-7):");
            bool result = int.TryParse(Console.ReadLine(), out int day); // Булиана для проверки корректности входящего значения
            if (!result)
            {                                                 // Выводим сообщение о некорректном символе, выходим из функции и заходим повторно 
                Console.WriteLine("Некорректный символ");
                Sbey();
            }

            switch (day)
            {
                case 1: Console.WriteLine("Понедельник - 2 пары программирования, 1 пара физры и экономики"); break;
                case 2 or 4:
                    int week;
                    do
                    {
                        Console.WriteLine("Какая это неделя? (1-2):");
                        bool result_2 = int.TryParse(Console.ReadLine(),out week);
                     
                        if (!result_2)
                        { 
                            Console.WriteLine("Не введено число 1-2."); 
                        }
                        else if (result_2 && (week == 1 || week == 2)) // Проверка на корректность ввода
                        {
                            break; // Выход из цикла, если введено корректное значение
                        }
                        else
                        {
                            Console.WriteLine("Неверное число недели.");
                        }
                    } while (true); // Цикл продолжается, пока не будет введено корректное значение

                    switch (week)
                    {
                        case 1:
                            if (day == 2) { Console.WriteLine("Вторник, 4 пары программирования"); }
                            else if (day == 4) { Console.WriteLine("Четверг, 3 пары программирования и физра"); }
                            break;
                        case 2:
                            if (day == 2) { Console.WriteLine("Вторник, 3 пары программирования"); }
                            else if (day == 4) { Console.WriteLine("Четверг, 3 пары программирования и алгебра"); }
                            break;
                    }
                    break;
                case 3: Console.WriteLine("Среда - 2 пары программирования 1 пара экономики"); break;
                case 5: Console.WriteLine("Пятница - 4 пары программирования"); break;
                case 6: Console.WriteLine("Суббота - Выходной"); break;
                case 7: Console.WriteLine("Воскресенье - Выходной"); break;
                default: Console.WriteLine("Неверное число"); break;
            }         
            Sbey(); // перевызов функции во избежание автоматического завершения 
        }
    }
}
