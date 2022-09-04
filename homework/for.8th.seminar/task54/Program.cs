/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/


int[,] initialArray = new int[4, 4]; 
Console.WriteLine();
FillArray(initialArray);
PrintArray(initialArray);
Console.WriteLine();
SortingRows(initialArray);
PrintArray(initialArray);


void FillArray(int[,] initialArray)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            initialArray[i, j] = new Random().Next(0, 30);
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


void SortingRows(int[,] initialArray)
{
    for (int i = 0; i < initialArray.GetLength(0); i++)
    {
        for (int j = 0; j < initialArray.GetLength(1); j++)
        {
            for (int g = j+1; g < initialArray.GetLength(1); g++) /* g-соседняя позиция j для сравнения
            и поиска наибольшего числа. Сортируем пузырьковым методом. */
            {
                if (initialArray[i, j] < initialArray[i, g])
                {
                    int temp = initialArray[i, j];
                    initialArray[i, j] = initialArray[i, g];
                    initialArray[i, g] = temp;
                }
            }
        }
    }
}
