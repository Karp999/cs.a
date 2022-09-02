/*Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива.
*/
int rows = new Random().Next(1, 10);
int columns = new Random().Next(1, 10);

int [,] array = GetArray(rows, columns, 0, 20);
PrintArray(array);
Console.WriteLine();

ChangeArray(array);
PrintArray(array);

int [,] GetArray(int rows, int columns, int min, int max)
{
    int [,] result = new int [rows,columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            result[i,j] = new Random().Next(min, max);
        }
    }
    return result;
}

void PrintArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int [,] ChangeArray(int[,] array)
{
    int change = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            change = array[0,j];
            array[0,j] = array[array.GetLength(0)-1,j];
            array[array.GetLength(0)-1,j] = change;
        }
    }
    return array;
}