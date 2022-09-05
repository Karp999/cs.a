/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] firstMatrix = new int[2, 2];
int[,] secondMatrix = new int[2, 2];
/* Для умножения матриц количество столбцов и строк матриц должно совпадать, 
поэтому создаю две матрицы 2*2, как в примере. */
Console.WriteLine();

FillMatrix(firstMatrix, secondMatrix);
PrintMatrix(firstMatrix, secondMatrix);
Console.WriteLine();

int[,] CommonMatrix = MatrixMultiplication(firstMatrix, secondMatrix);
Console.WriteLine("Произведение двух матриц: ");
Console.WriteLine();
PrintCommonMatrix(CommonMatrix);
Console.WriteLine();

void FillMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            firstMatrix[i, j] = new Random().Next(0, 7);
        }
    }
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            secondMatrix[i, j] = new Random().Next(0, 7);
        }
    }
}

void PrintMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    Console.WriteLine(" Первая матрица:");
    Console.WriteLine();
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            Console.Write($" | {firstMatrix[i, j]} | "); //вертикальные знаки для чёткости и красоты вывода
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    Console.WriteLine(" Вторая матрица:");
    Console.WriteLine();
    for (int i = 0; i < secondMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {

            Console.Write($" | {secondMatrix[i, j]} | "); //вертикальные знаки для чёткости и красоты вывода
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            for (int v = 0; v < firstMatrix.GetLength(1); v++)
            {
                resultMatrix[i, j] = resultMatrix[i, j] + firstMatrix[i, v] * secondMatrix[v, j];
            }
        }
    }
    return resultMatrix;
}

void PrintCommonMatrix(int[,] MatrixMultiplication)
{
    for (int i = 0; i < MatrixMultiplication.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixMultiplication.GetLength(1); j++)
        {
            Console.Write($" | {MatrixMultiplication[i, j]} | ");
        }
        Console.WriteLine();
    }
}