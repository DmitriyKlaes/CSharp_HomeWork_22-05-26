/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

//Второй вариант решения задачи через одну функцию напрямую. Первый вариант с массивом мне нравится больше =)

void FibonacciNumbersPrint(int number)
{
    int firstNumber = 0;
    int secondNumber = 1;
    int nextNumber = 0;
    Console.Write($"{firstNumber} {secondNumber} ");
    for (int i = 2; i < number; i++)
    {
        nextNumber = firstNumber + secondNumber;
        Console.Write(nextNumber);
        if (i < number - 1)
        {
            Console.Write(" ");
        }
        firstNumber = secondNumber;
        secondNumber = nextNumber;
    }
    Console.WriteLine();
}
Console.Write("\nВведите количество первых чисел Фибоначчи: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"\nПервые {number} чисел Фибоначчи -> ");
FibonacciNumbersPrint(number);