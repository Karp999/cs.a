/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


double[,] initialArray = new double[3, 4]; //взяла указанный пример в основу: 3 строки, 4 столбца
Console.WriteLine();
FillArray(initialArray);
PrintArray(initialArray);
ColumnAverage(initialArray);


void FillArray(double[,] initialArray)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            initialArray[i, j] = new Random().Next(-10, 10);
        }
    }
}

void PrintArray(double[,] initialArray)
{
    for (int i = 0; i < initialArray.GetLength(0); i++)
    {
        for (int j = 0; j < initialArray.GetLength(1); j++)
        {
            Console.Write($" | {initialArray[i, j]} | "); //вертикальные знаки для чёткости и красоты вывода
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ColumnAverage(double[,] initialArray)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < initialArray.GetLength(1); j++) /* войдём в столбец, подсчёт будем производить по строкам 
    в столбце, поэтому цикл строк будет находиться в цикле столбцов */
    {
        double average = 0; //ввела переменную среднего значения,изначально равна нулю
        for (int i = 0; i < initialArray.GetLength(0); i++)
        {
            average = (average + initialArray[i, j]);
           // average = Math.Round(average, 1);
        }
        Console.Write($" {Math.Round(average/3,1)}  ");
    }
    Console.WriteLine();
    Console.WriteLine();
}
