// Написать программу, которая из имеющегося массива строк формирует массив из строк,
//  длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//  либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//  лучше обойтись исключительно массивами.

bool run = true;
while (run)
{
    Console.Clear();
    Console.Write("Задайте размер массива: ");
    int arraySize = int.Parse(Console.ReadLine());
    string[] array = new string[arraySize];

    void FillArray(string[] collection)
    {
        Console.WriteLine("Введите элементы массива через клавишу Enter");
        for (int i = 0; i < collection.Length; i++)
        {
            collection[i] = Console.ReadLine();
        }
    }

    int GetSize(string[] col)
    {
        int size = 0;
        for (int i = 0; i < col.Length; i++)
        {
            if (col[i].Length <= 3)
                size++;
        }
        return size;
    }

    string[] FillNewArray(string[] arr, string[] newArr)
    {
        int index = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                newArr[index] = arr[i];
                index++;
            }
        }
        return newArr;
    }

    string PrintArray(string[] arr)
    {
        string res = $"[";
        for (int i = 0; i < arr.Length; i++)
        {
            if (i < arr.Length - 1)
                res += $"{arr[i]}" + $", ";
            else
                res += $"{arr[i]}";
        }
        res += $"]";
        return res;
    }

    FillArray(array);
    int newSize = GetSize(array);
    string[] newArray = new string[newSize];
    newArray = FillNewArray(array, newArray);
    string input = PrintArray(array);
    string output = PrintArray(newArray);
    Console.WriteLine();
    Console.Write(input);
    Console.Write(" -> ");
    Console.WriteLine(output);
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Попробуем ещё раз? y/n");
    run = Console.ReadKey().Key == ConsoleKey.Y;
    Console.WriteLine("Спасибо что воспользовались моим приложением");
}