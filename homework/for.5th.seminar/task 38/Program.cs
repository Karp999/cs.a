/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
Пример:
[3 7 22 2 78] -> 76
*/
double[] GetArray(int size, int minValue, int maxValue)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
        Random r = new Random();
        double digit = r.NextDouble();
        result[i] = result[i] * digit;
        result[i] = Math.Round(result[i], 1);
        Console.Write($"{result[i]} ");
    }
    return result;
}
Console.WriteLine(); /*эта пустая строка и пустые строки в самом низу кода для красоты и читабельности отображения,
можно и без них */

double[] DoubleArray = GetArray(7, -10, 10);
Console.WriteLine();
double minNum = 0;
double maxNum = 0;
for (int i = 0; i < DoubleArray.Length; i++)
{
    if (DoubleArray[i] < minNum)
    {
        minNum = DoubleArray[i];
    }
    else
    if (DoubleArray[i] > maxNum)
    {
        maxNum = DoubleArray[i];
    }
}
Console.WriteLine();
Console.WriteLine($"Разница между максимальным {maxNum} и минимальным {minNum} элементами массива равна:{maxNum - minNum}");
Console.WriteLine();
Console.WriteLine();