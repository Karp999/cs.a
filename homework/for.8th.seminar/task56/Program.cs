/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/


int[,] initialArray = new int[3, 4];
Console.WriteLine();
FillArray(initialArray);
PrintArray(initialArray);
Console.WriteLine();
SumRows(initialArray);
Console.WriteLine();


void FillArray(int[,] initialArray)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            initialArray[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] initialArray)
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

void SumRows(int[,] initialArray)
{
    int sum = 0;
    int minSumRows = 0;
    int index = 0;
    for (int i = 0; i < initialArray.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < initialArray.GetLength(1); j++)
        {
            sum = sum + initialArray[i, j];
        }
        Console.WriteLine($"Сумма строки {i + 1} равна {sum}.");
        
        if (i == 0)
        {
            minSumRows = sum;
        }
        else if (sum < minSumRows)
        {
            minSumRows = sum;
            index = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Строка с наименьшей суммой элементов -> {index + 1}.");
}



