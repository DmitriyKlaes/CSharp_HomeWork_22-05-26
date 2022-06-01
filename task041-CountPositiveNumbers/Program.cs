/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

int CountPositiveNumbers()
{
    int result = 0;
    int numberFromUser;
    while (int.TryParse(Console.ReadLine(), out numberFromUser))
    {
        if (numberFromUser > 0)
        {
            result++;
        }
    }
    return result;
}

Console.WriteLine("Введите любое кол-во чисел. Для завершения ввода повторно нажмите Enter:");
int count = CountPositiveNumbers();
System.Console.WriteLine($"Кол-во чисел больше нуля: {count}");