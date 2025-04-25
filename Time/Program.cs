using System;
using System.ComponentModel.Design;
using System.Xml.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Format();
        }
        static void Format()
        {
            Console.WriteLine("Какой формат времени вы хотите использовать? Единица - 12-ти часовой формат, Двойка - 24-часовой", "(1-2):");
            bool result = int.TryParse(Console.ReadLine(), out int hs);
            if (!result)
            {
                Console.WriteLine("Некорректный символ");
                Format();
            }
            if (hs == 1)
            {
                Drip1();
            }
            else if (hs == 2)
            {
                Drip2();
            }
        }

        static void Drip1()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("1.Введите число от 0 до 23 чтобы вывести время", "(0-25)" + "\n Введите число 25 для выхода из программы" + "\nВведите число 24 для перехода к 24-ом часовом формату","(0-23):");
                bool result = int.TryParse(Console.ReadLine(), out int hour12); // Булиана для проверки корректности входящего значения
                if (!result)
                {                                                 // Выводим сообщение о некорректном символе, выходим из функции и заходим повторно 
                    Console.WriteLine("Некорректный символ");
                    Drip1();
                }

                switch (hour12)
                {
                    case 0: Console.WriteLine("12 PM"); break;
                    case 1: Console.WriteLine("1 PM"); break;
                    case 2: Console.WriteLine("2 PM"); break;
                    case 3: Console.WriteLine("3 PM"); break;
                    case 4: Console.WriteLine("4 PM"); break;
                    case 5: Console.WriteLine("5 PM"); break;
                    case 6: Console.WriteLine("6 PM"); break;
                    case 7: Console.WriteLine("7 PM"); break;
                    case 8: Console.WriteLine("8 PM"); break;
                    case 9: Console.WriteLine("9 PM"); break;
                    case 10: Console.WriteLine("10 PM"); break;
                    case 11: Console.WriteLine("11 PM"); break;
                    case 12: Console.WriteLine("12 AM"); break;
                    case 13: Console.WriteLine("1 AM"); break;
                    case 14: Console.WriteLine("2 AM"); break;
                    case 15: Console.WriteLine("3 AM"); break;
                    case 16: Console.WriteLine("4 AM"); break;
                    case 17: Console.WriteLine("5 AM"); break;
                    case 18: Console.WriteLine("6 AM"); break;
                    case 19: Console.WriteLine("7 AM"); break;
                    case 20: Console.WriteLine("8 AM"); break;
                    case 21: Console.WriteLine("9 AM"); break;
                    case 22: Console.WriteLine("10 AM"); break;
                    case 23: Console.WriteLine("11 AM"); break;
                    case 24: running = false; break;
                    case 25:
                        running = false;
                        Drip2(); // Переключение на 12-ти часовой формат
                        break;
                    default: Console.WriteLine("Ошибка. В сутках - 12 часов"); break;

                }
            }
        }

        static void Drip2()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("1.Введите число от 0 до 23 что бы вывести время" +
                                  "\n2.Введите число 24 для смены формата на 12-ти часовой формат" +
                                  "\n3.Введите число 25 для выхода из программы");

                bool result = int.TryParse(Console.ReadLine(), out int hour24); // Булиана для проверки корректности входящего значения
                if (!result)
                {
                    // Выводим сообщение о некорректном символе и продолжаем цикл
                    Console.WriteLine("Некорректный символ");
                    continue;
                }

                switch (hour24)
                {
                    case 0: Console.WriteLine("12 часов ночи"); break;
                    case 1: Console.WriteLine("час ночи"); break;
                    case 2: Console.WriteLine("2 часа ночи"); break;
                    case 3: Console.WriteLine("3 часа ночи"); break;
                    case 4: Console.WriteLine("4 часа ночи"); break;
                    case 5: Console.WriteLine("5 часов ночи"); break;
                    case 6: Console.WriteLine("6 часов утра"); break;
                    case 7: Console.WriteLine("7 часов утра"); break;
                    case 8: Console.WriteLine("8 часов утра"); break;
                    case 9: Console.WriteLine("9 часов утра"); break;
                    case 10: Console.WriteLine("10 часов утра"); break;
                    case 11: Console.WriteLine("11 часов утра"); break;
                    case 12: Console.WriteLine("12 часов утра"); break;
                    case 13: Console.WriteLine("час дня"); break;
                    case 14: Console.WriteLine("2 часа дня"); break;
                    case 15: Console.WriteLine("3 часа дня"); break;
                    case 16: Console.WriteLine("4 часа дня"); break;
                    case 17: Console.WriteLine("5 часов дня"); break;
                    case 18: Console.WriteLine("6 часов вечера"); break;
                    case 19: Console.WriteLine("7 часов вечера"); break;
                    case 20: Console.WriteLine("8 часов вечера"); break;
                    case 21: Console.WriteLine("9 часов вечера"); break;
                    case 22: Console.WriteLine("10 часов вечера"); break;
                    case 23: Console.WriteLine("11 часов вечера"); break;
                    case 24:
                        running = false;
                        Drip1(); // Переключение на 12-ти часовой формат
                        break;
                    case 25:
                        running = false; // Выход из программы
                        break;
                    default:
                        Console.WriteLine("Ошибка. В сутках - 24 часа");
                        break;
                }
            }
        }

       
    }
}
