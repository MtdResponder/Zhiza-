using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Вычислить количество дней между датами");
            Console.WriteLine("2. Вычислить количество рабочих дней между датами");
            Console.WriteLine("3. Добавить рабочие дни к дате");
            Console.WriteLine("4. Выход");
            Console.Write("Выберите опцию: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Введите первую дату (гггг-мм-дд): ");
                    bool result1 = DateTime.TryParse(Console.ReadLine(), out DateTime date1);
                    if (!result1 )
                    {                                                 // Выводим сообщение о некорректном символе, выходим из функции и заходим повторно 
                        Console.WriteLine("Некорректный символ");
                        Main();
                    }
                    Console.Write("Введите вторую дату (гггг-мм-дд): ");
                    bool result2 = DateTime.TryParse(Console.ReadLine(), out DateTime date2);
                    if (!result2)
                    {                                                 // Выводим сообщение о некорректном символе, выходим из функции и заходим повторно 
                        Console.WriteLine("Некорректный символ");
                        Main();
                    }
                    Console.WriteLine($"Разница в днях: {DaysBetween(date1, date2)}\n");
                    break;
                case "2":
                    Console.Write("Введите первую дату (гггг-мм-дд): ");
                    bool resultStartDate = DateTime.TryParse(Console.ReadLine(), out DateTime startDate);
                    if (!resultStartDate)
                    {                                                 // Выводим сообщение о некорректном символе, выходим из функции и заходим повторно 
                        Console.WriteLine("Некорректный символ");
                        Main();
                    }
                    Console.Write("Введите вторую дату (гггг-мм-дд): ");
                    bool resutlEndDate = DateTime.TryParse(Console.ReadLine(), out DateTime endDate);
                    if (!resutlEndDate)
                    {                                                 // Выводим сообщение о некорректном символе, выходим из функции и заходим повторно 
                        Console.WriteLine("Некорректный символ");
                        Main();
                    }
                    Console.WriteLine($"Количество рабочих дней: {BusinessDaysBetween(startDate, endDate)}\n");
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Неверный ввод, попробуйте снова.\n");
                    break;
            }
        }
    }

    static int DaysBetween(DateTime date1, DateTime date2)
    {
        return Math.Abs((date2 - date1).Days);
    }

    static int BusinessDaysBetween(DateTime startDate, DateTime endDate)
    {
        int businessDays = 0;
        DateTime date = startDate;
        while (date <= endDate)
        {
            if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
            {
                businessDays++;
            }
            date = date.AddDays(1);
        }
        return businessDays;
    }

    static DateTime AddBusinessDays(DateTime date, int days)
    {
        int addedDays = 0;
        while (addedDays < days)
        {
            date = date.AddDays(1);
            if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
            {
                addedDays++;
            }
        }
        return date;
    }
}