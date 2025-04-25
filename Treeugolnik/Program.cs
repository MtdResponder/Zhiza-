class Program
{
    static void Main()
    {
        int[] input = new int[3];
        for (int i = 0; i < 3; i++)
        {
            bool result = int.TryParse(Console.ReadLine(), out int value);
            if (!result)
            {
                Console.WriteLine("Некорректный символ");
                Main();
            }

            input[i] = value;
        }

        // Достаём числа из массива
        int side1 = input[0];
        int side2 = input[1];
        int side3 = input[2];

        // Проверяем, является ли треугольник равносторонним (все стороны равны)
        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("Треугольник равносторонний");
        }
        // Проверяем, является ли треугольник равнобедренным (две стороны равны)
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            Console.WriteLine("Треугольник равнобедренный");
        }
        // Если ни одно из условий не выполнено, значит треугольник разносторонний
        else
        {
            Console.WriteLine("Треугольник разносторонний");
        }
        Main();
    }
}
