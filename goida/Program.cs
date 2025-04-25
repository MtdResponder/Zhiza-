using System;

class Program
{
    static void Main()
    {
        bool continueCalculating = true;

        while (continueCalculating)
        {
            // Запрашиваем у клиента два числа
            Console.Write("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Запрашиваем у клиента выбор оператора
            Console.Write("Введите оператор (+, -, *, /, %, ^): ");
            string operatorChoice = Console.ReadLine();

            double result = 0;

            // Выполняем выбранную операцию 
            switch (operatorChoice)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    // Проверка деления на ноль
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: поделить на ноль невозможно.");
                        continue;
                    }
                    break;
                case "%":
                    // Остаток от деления
                    result = num1 % num2;
                    break;
                case "^":
                    result = Math.Pow(num1, num2);
                    break;
                default:
                    Console.WriteLine("Ошибка: неверно указан оператор.");
                    continue;
            }

            // Вывод результата
            Console.WriteLine($"Результат:{result}");

            // Запрос на продолжение
            Console.Write("Желаете продолжить" + "\nДа?" + "\nНет?");
            string continueResponse = Console.ReadLine().ToLower();

            if (continueResponse != "да")
            {
                continueCalculating = false;
            }
        }
        Console.WriteLine("Программа завершена.");

    }
}