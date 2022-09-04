/*Задача 55: Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя.
*/


int rows = new Random().Next(1,10);
int columns = new Random().Next(1,10);
//int columns = rows; для проверки, чтобы не пришлось ждать равенства строк и столбцов

int [,] array = GetArray(rows, columns, 0, 20);
PrintArray(array);
Console.WriteLine();

if(array.GetLength(0) == array.GetLength(1))
{
    ChangeArray(array);
}
else
{
    Console.WriteLine("Количество строк не равно количеству столбцов");
}
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
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < i; j++)/*в условие прописываем j<i чтобы вовремя выйти из цикла, т.е. при i=2, +
    если j будет 2 начнется возвращение массива к изначальному виду */
   //Аня: у Виталия было j=i(Аня,проверь)
    {
        int change = array[i,j];
        array[i,j] = array[j,i];
        array[j,i] = change;
    }
}
return array;
}
