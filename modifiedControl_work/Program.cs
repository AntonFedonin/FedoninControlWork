bool run = true;
while (run)
{
    Console.Clear();
    Console.Write("Задайте размер массива: ");
    int arraySize = int.Parse(Console.ReadLine());
    Console.Write("Укажите длину искомых элементов: ");
    int desiredLength = int.Parse(Console.ReadLine());
    string[] array = new string[arraySize];

    void FillArray(string[] collection)
    {
        Console.WriteLine("Введите элементы массива через клавишу Enter");
        for (int i = 0; i < collection.Length; i++)
        {
            collection[i] = Console.ReadLine();
        }
    }

    int GetSize(string[] col, int len)
    {
        int size = 0;
        for (int i = 0; i < col.Length; i++)
        {
            if (col[i].Length <= len)
                size++;
        }
        return size;
    }

    string[] FillNewArray(string[] arr, string[] newArr, int len)
    {
        int index = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= len)
            {
                newArr[index] = arr[i];
                index++;
            }
        }
        return newArr;
    }

    void PrintArray(string[] col)
    {
        Console.Write("[");
        for (int i = 0; i < col.Length; i++)
        {
            if (i < col.Length - 1)
                Console.Write($"{col[i]}" + $", ");
            else
                Console.Write($"{col[i]}");
        }
        Console.Write("]");
    }

    FillArray(array);
    int newSize = GetSize(array, desiredLength);
    if (newSize == 0)
    {
        PrintArray(array);
        Console.WriteLine();
        Console.WriteLine("Нет элементов для нового массива");
        Console.WriteLine("Попробуем ещё раз? y/n");
        run = Console.ReadKey().Key == ConsoleKey.Y;
        Console.WriteLine("Спасибо, что воспользовались моим приложением");
    }
    else
    {
        string[] newArray = new string[newSize];
        newArray = FillNewArray(array, newArray, desiredLength);
        Console.WriteLine();
        PrintArray(array);
        Console.Write(" -> ");
        PrintArray(newArray);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Попробуем ещё раз? y/n");
        run = Console.ReadKey().Key == ConsoleKey.Y;
        Console.WriteLine("Спасибо, что воспользовались моим приложением");
    }
}