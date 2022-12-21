// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам

Console.WriteLine("Введите длину массива: ");

int initialArrayLength = Convert.ToInt32(Console.ReadLine());

while (initialArrayLength < 1)
{
    Console.WriteLine("Введено неверное значение, длина массива должна быть больше 0. Введите длину массива: ");
    initialArrayLength = Convert.ToInt32(Console.ReadLine());
}

string[] FillArray(int arrayLength)
{
    string[] initialArray = new string[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент массива: ");
        initialArray[i] = Console.ReadLine();
    }
    return initialArray;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"\u0022{array[i]}\u0022, ");
    }
    if (array.Length > 0) 
    {
        Console.Write($"\u0022{array[array.Length - 1]}\u0022");
    }
    Console.WriteLine("]");
}

string[] array = FillArray(initialArrayLength);
PrintArray(array);

string[] CreateArray(string[] array)
{
    int newArrayLength = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) newArrayLength++;
    }

    string[] newArray = new string[newArrayLength];
    int count = 0;

    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <= 3)
        {
            newArray[count] = array[j];
            count++;
        }
    }
    return newArray;
}

PrintArray(CreateArray(array));
