using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите:" + "\nЦифру" + "\nБукву" + "\nСимвол");
        char chr = Console.ReadKey().KeyChar;
        Console.WriteLine(); // Переход на новую строку после ввода символа

        if (chr >= '0' && chr <= '9')
        {
            Console.WriteLine("Это: цифра");
        }
        else if (chr >= 'A' && chr <= 'Z')
        {
            Console.WriteLine("Это: заглавная буква");
        }
        else if (chr >= 'a' && chr <= 'z')
        {
            Console.WriteLine("Это: строчная буква");
        }
        else
        {
            Console.WriteLine("Это: спецсимвол");
        }
        Main();
    }
}
