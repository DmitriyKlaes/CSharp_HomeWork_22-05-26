/*
Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
*/

int[] RandomFillArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(1, 100);
    }
    return result;
}

int[] ElementCopyArray(int[] arrayForCopy)
{
    int[] result = new int[arrayForCopy.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = arrayForCopy[i];
    }
    return result;
}

void PrintArray(int[] arrayForPrint, int color) // аргумент color "1" печатает зеленый, "2" печатает голубой массив
{
    if (color == 1)
    {
        Console.ForegroundColor = ConsoleColor.Green;

    }
    else if (color == 2)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;

    }
    Console.Write("[");
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        Console.Write(arrayForPrint[i]);
        if (i < arrayForPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
    Console.ResetColor();
}

Console.Write("Введите длинну массива случайных чисел от 1 до 99: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] givenArray = RandomFillArray(length);
Console.WriteLine("\nЗаданный массив: ");
PrintArray(givenArray, 1);

int[] copiedArray = ElementCopyArray(givenArray);
Console.WriteLine("\nСкопированный массив: ");
PrintArray(copiedArray, 2);