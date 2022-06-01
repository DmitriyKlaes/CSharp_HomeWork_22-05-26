/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

//Первый вариант решения задачи через 2 функции и массив. Второй вариант находится в папке task044-Var#2-fibonacciN.

int[] FibonacciNumbers(int length)
{
    int[] result = new int[length];
    result[0] = 0;
    result[1] = 1;
    for (int i = 2; i < result.Length; i++)
    {
        result[i] = result[i - 1] + result[i - 2];
    }
    return result;
}

void PrintFibonacciNumbers(int[] fibonacciArray)
{
    for (int i = 0; i < fibonacciArray.Length; i++)
    {
        Console.Write(fibonacciArray[i]);
        if (i < fibonacciArray.Length -1)
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}

Console.Write("\nВведите количество первых чисел Фибоначчи: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] fibonacciArray = FibonacciNumbers(number);
Console.Write($"\nПервые {number} чисел Фибоначчи -> ");
PrintFibonacciNumbers(fibonacciArray);