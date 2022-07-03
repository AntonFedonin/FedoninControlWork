// Написать программу, которая из имеющегося массива строк формирует массив из строк,
//  длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//  либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//  лучше обойтись исключительно массивами.

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
    int index=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArr[index]=arr[i];
            index++;
        }
    }
    return newArr;
}