/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] matrix = new int[3,4];
/* int minValue = -10;
int maxValue = 10; */
for (int i=0; i<matrix.GetLength(0); i++)
{
    for (int j=0; j<matrix.GetLength(1); j++)
    {
        /* int result[i,j] = new Random().Next(minValue, maxValue); */
        Console.Write($"{matrix[i,j]}");
    }
    Console.WriteLine();
}


/*

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" | {array[i, j]} | ");
            //поставила вертикальные линии в выводе, чтоб зрительно чётче разделение было и для красоты
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ColumnAverage(int m, int n, int minValue, int maxValue)
{
    int[,] AverageArray = new int[m, n];

    int AverageColumnA =
    int AverageColumnB =
    int AverageColumnC =
    int AverageColumnD =

    Console.Write($"{AverageColumnA}, {AverageColumnA}, {AverageColumnA}, {AverageColumnA}");
}
*/