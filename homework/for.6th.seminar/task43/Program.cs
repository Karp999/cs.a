/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Пример:
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
Console.Clear();
Console.Write($"Введите значение b1: ");
double userFirstB = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите значение b2: ");
double userSecondB = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите значение k1: ");
double userFirstK = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите значение k2: ");
double userSecondK = Convert.ToInt32(Console.ReadLine());

double x = (userSecondB - userFirstB) / (userFirstK - userSecondK);
double y = userFirstK * x + userFirstB;

Console.WriteLine($"Прямые y = k1 * x + b1 и y = k2 * x + b2 пересекаются в точках x = ({Math.Round(x, 2)}) , y = ({Math.Round(y, 2)})."); 