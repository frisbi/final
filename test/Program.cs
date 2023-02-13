// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["2"]
// ["Russia", "Denmark", "Kazan"] -> []


string[] CreateArray()
{
    Console.WriteLine("Введите количество элементов массива ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array1 = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        array1[i] = Convert.ToString(Console.ReadLine());
    }
    return array1;
}

void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.Clear();
string[] array1 = CreateArray();
string[] array2 = new string[array1.Length];
PrintArray(array2);
SecondArrayWithIF(array1, array2);
PrintArray(array2);