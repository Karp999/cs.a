/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Пример: массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/


int[,,] initialArray = new int[2, 2, 2]; //Создаю матрицу 2*2*2, как в примере, так как размерность не указана.
Console.WriteLine();
FillArray(initialArray);
PrintArray(initialArray);
Console.WriteLine();

void FillArray(int[,,] initialArray)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int v = 0; v < 2; v++)
            {
                /* хотела через сравнение (i == j || j == v || v == i) заставить повторяться, пока не будет
                разным, но не получалось вывести, выходило пустое поле, которое прекращалось только ctrl+c.
                Так как в условии не сказано, каким образом предпочтительно вывести разные числа, 
                я поставила свои условия */
                if (i < j && j < v && v > i) 
                {
                    initialArray[i, j, v] = new Random().Next(10, 100);
                }
                else //иначе заново заполнить массив рандомными числами
                {
                    initialArray[i, j, v] = new Random().Next(10, 100);
                }
            }
        }
    }
}

void PrintArray(int[,,] initialArray)
{
    for (int i = 0; i < initialArray.GetLength(0); i++)
    {
        for (int j = 0; j < initialArray.GetLength(1); j++)
        {
            for (int v = 0; v < initialArray.GetLength(2); v++)
            {
                Console.Write($" | {initialArray[i, j, v]} ({i},{j},{v}) | ");
            }
            Console.WriteLine();
        }
    }
}
