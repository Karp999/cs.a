/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. ( - необязательная)
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

/* взяла в основу комментарии с семинара и информацию из Интернета, 
что помогло разобраться в заполнении спирали. */
int[,] SpiralArray = new int[4, 4];
Console.WriteLine();
FillSpiralArray(SpiralArray);
PrintArray(SpiralArray);
Console.WriteLine();

void FillSpiralArray (int[,] SpiralArray) //метод заполнения массива
{
    // точки начала и конца сторон квадрата первоначально все приравниваем к нулю
    int movingFromA = 0; 
    int movingToA = 0;
    int movingFromB = 0;
    int movingToB = 0;

    int count = 1;
    int i = 0;
    int j = 0;
    while (count <= SpiralArray.GetLength(0) * SpiralArray.GetLength(1))
    {
        SpiralArray[i, j] = count;
        
        if (i == movingFromA && j < SpiralArray.GetLength(1) - movingToB - 1) // движемся вправо
        {
            j++;
        }
        else if (j == SpiralArray.GetLength(1) - movingToB - 1 && i < SpiralArray.GetLength(0) - movingToA - 1)  // движемся вниз
        {
            i++;
        }
        else if (i == SpiralArray.GetLength(0) - movingToA - 1 && j > movingFromB) // движемся влево
        {
            j--;
        }
        else 
        {
            i--;
        }

        if ((i == movingFromA + 1) && (j == movingFromB) && (movingFromB != SpiralArray.GetLength(1) - movingToB - 1))
        {
            movingFromA++;
            movingToA++;
            movingFromB++;
            movingToB++;
        }
        count++;
    }
}

void PrintArray(int[,] array) //метод печати массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10) Console.Write($" 0{array[i, j]}"); /*добавила 0, чтоб однозначные 
            числа начинались с нуля: 01,02,03... */
            else Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
}
