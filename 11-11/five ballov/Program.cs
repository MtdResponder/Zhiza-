//Отсортировать массив из 10 случайных чисел по возрастанию, используя Array.Sort().

{
    int[] cska = { 5, 3, 8, 1, 11, 12, 40, 52, 9, 32 };

    Array.Sort(cska);
    foreach (int n in cska)
        Console.WriteLine(n);
    int min = cska.First();
    int max = cska.Last();
    Console.WriteLine($"Минимум: {min}");
    Console.WriteLine($"Максимум: {max}");
}

//Написать свою реализацию сортировки пузырьком
{
    //метод обмена элементов
    void Swap(ref int elm1, ref int elm2)
    {
        int temp = elm1;
        elm1 = elm2;
        elm2 = temp;
    }
    //сортировка пузырьком
    int[] BubbleSort(int[] massive)
    {
        int len = massive.Length;
        for (int i = 1; i < len; i++)
        {
            for (int j = 0; j < len - i; j++)
            {
                if (massive[j] > massive[j + 1])
                {
                    Swap(ref massive[j], ref massive[j + 1]);
                }
            }
        }
        return massive;
    }
    Console.WriteLine("Сортировка пузырьком");
    string[] parts = Console.ReadLine()!.Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
    var sort = new int[parts.Length];
    for (int i = 0; i < parts.Length; i++)
    {
        sort[i] = Convert.ToInt32(parts[i]);
    }

    Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", BubbleSort(sort)));
}

//Ввести строку и вывести каждый символ на новой строке.

{
    var text = "normal map";
    foreach (var character in text)
    {
        Console.WriteLine(character);
    }
}

//Вывести длину введённой строки.

{
    Console.Write("Введите строку: ");
    string input = Console.ReadLine();
    int length = input.Length;

    Console.WriteLine("Длина введённой строки: " + length);
}

//Преобразовать строку в верхний регистр.

{
    {
        string text = "LeGaCytoPBR";
        Console.WriteLine(text.ToUpper()); // LeGaCytoPBR
    }
}

//. Разделить строку на слова и вывести их по одному.
{
    Console.Write("Введите строку: ");
    string input = Console.ReadLine();

    // Разделяем строку на слова по пробелам
    string[] slova = input.Split(' ');

    // Выводим каждое слово на новой строке
    foreach (string word in slova)
    {
        Console.WriteLine(word);
    }
}

//Найти и заменить все вхождения слова 

{
    string text = "Кот сидел на перилах, с перил упал Кот, только очень сильно";

    text = text.Replace("Кот", "Пёс");
    Console.WriteLine(text);    // Пёс
}