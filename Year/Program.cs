namespace Year
{
    class Program
    {
        static void Main(string[] args)
        {
            Zxc();
        }
        static void Zxc()
        {
            Console.WriteLine("1.Выберите время года" + "\nЗима - 1" + "\nВесна - 2" + "\nЛето - 3" + "\nОсень - 4");
            bool result = int.TryParse(Console.ReadLine(), out int type);
            if (!result)
            {
                Console.WriteLine("Некорректный символ");
                Zxc();
            }
            if (type == 1)
            {
                Winter();
            }
            else if (type == 2)
            {
                Spring();
            }
            else if (type == 3)
            {
                Summer();
            }
            else if (type == 4)
            {
                Autumun();
            }
            else
            {
                Console.WriteLine("Неверное значение");
                Zxc();
            }
        }
        static void Winter()
        {
            Console.WriteLine("Напишите число месяца", "(1-3):");
            bool result = int.TryParse(Console.ReadLine(), out int MonthW);
            if (!result)
            {
                Console.WriteLine("Некорректный символ");
                Winter();
            }
            switch (MonthW)
            {
                case 1: Console.WriteLine("Декабрь"); break;
                case 2: Console.WriteLine("Январь"); break;
                case 3: Console.WriteLine("Февраль"); break;
                default: Console.WriteLine("Ошибка. В сезоне - 3 месяца"); break;

            }
            Zxc();
        }
        static void Spring()
        {
            Console.WriteLine("Напишите число месяца", "(1-3):");
            bool result = int.TryParse(Console.ReadLine(), out int MonthS);
            if (!result)
            {
                Console.WriteLine("Некорректный символ");
                Spring();
            }
            switch (MonthS)
            {
                case 1: Console.WriteLine("Март"); break;
                case 2: Console.WriteLine("Апрель"); break;
                case 3: Console.WriteLine("Май"); break;
                default: Console.WriteLine("Ошибка. В сезоне - 3 месяца"); break;
            }
            Zxc();
        }
        static void Summer()
        {
            Console.WriteLine("Напишите число месяца", "(1-3):");
            bool result = int.TryParse(Console.ReadLine(), out int MonthSr);
            if (!result)
            {
                Console.WriteLine("Некорректный символ");
                Summer();
            }
            switch (MonthSr)
            {
                case 1: Console.WriteLine("Июнь"); break;
                case 2: Console.WriteLine("Июль"); break;
                case 3: Console.WriteLine("Август"); break;
                default: Console.WriteLine("Ошибка. В сезоне - 3 месяца"); break;
            }
            Zxc();
        }
        static void Autumun()
        {
            Console.WriteLine("Напишите число месяца", "(1-3):");
            bool result = int.TryParse(Console.ReadLine(), out int MonthA);
            if (!result)
            {
                Console.WriteLine("Некорректный символ");
                Autumun();
            }
            switch (MonthA)
            {
                case 1: Console.WriteLine("Cентябрь"); break;
                case 2: Console.WriteLine("Октябрь"); break;
                case 3: Console.WriteLine("Ноябрь"); break;
                default: Console.WriteLine("Ошибка. В сезоне - 3 месяца"); break;
            }
            Zxc();
        }

    }
}
