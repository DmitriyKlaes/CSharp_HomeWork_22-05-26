/*
Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 0,5)
*/

double[] FillArrayCoordinates()
{
    double[] result = new double[4];
    Console.WriteLine("Введите коэффициенты для первой прямой (b1 и k1): ");
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = Convert.ToDouble(Console.ReadLine());
        if (i == 1)
        {
            Console.WriteLine("Введите коэффициенты для второй прямой (b2 и k2): ");
        }

    }
    return result;
}

void IntersectionTwoLinesPrint(double[] arrayWithCoordinates)
{
    double coordX = (arrayWithCoordinates[0] - arrayWithCoordinates[2])
                  / (arrayWithCoordinates[3] - arrayWithCoordinates[1]);
    double coordY = arrayWithCoordinates[3] * coordX + arrayWithCoordinates[2];
    Console.WriteLine($"Координаты пересечения двух прямых: ({coordX} : {coordY})");
}

Console.WriteLine("Поиск точки пересечения двух прямых исходя из уравнений: y = k1 * x + b1, y = k2 * x + b2");
double[] coordinatesArray = FillArrayCoordinates();
IntersectionTwoLinesPrint(coordinatesArray);