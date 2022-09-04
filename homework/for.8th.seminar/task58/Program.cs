/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


int[,] firstArray = new int[4, 4];
int[,] secondArray = new int[4, 4];
//для умножения матриц количество столбцов и строк матриц должно совпадать, поэтому создаю две матрицы 4*4.
Console.WriteLine();
FillArray(firstArray,secondArray);
PrintArray(firstArray,secondArray);
Console.WriteLine();


void FillArray(int[,] firstArray, int[,] secondArray)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            firstArray[i, j] = new Random().Next(0, 10);
        }
    }
    for (int k = 0; k < 4; k++)
    {
        for (int v = 0; v < 4; v++)
        {
            secondArray[k, v] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] firstArray, int[,] secondArray)
{
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < firstArray.GetLength(1); j++)
        {
            Console.Write($" | {firstArray[i, j]} | "); //вертикальные знаки для чёткости и красоты вывода
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    for (int k = 0; k < secondArray.GetLength(0); k++)
    {
        for (int v = 0; v < secondArray.GetLength(1); v++)
        {
            Console.Write($" | {secondArray[k, v]} | "); //вертикальные знаки для чёткости и красоты вывода
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ArrayMultiplication (int[,] firstArray, int[,] secondArray)
{
    
}