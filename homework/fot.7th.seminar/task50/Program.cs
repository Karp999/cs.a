/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
(на вход именно поступает позиция элемента, можете разбить на две переменные или прописать в 
одну строку и конвертировать в два числа, комментарии в конце семинара по этой задаче)
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

Console.WriteLine();
Console.Write("Задайте количество строк для массива: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов для массива: ");
int userColumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = GetRandomArray(userRows, userColumns, -10, 10);
PrintArray(array);
FindRowAndColumn(array);

int[,] GetRandomArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" | {array[i, j]} | ");
        }
        Console.WriteLine();
    }
}

void FindRowAndColumn(int[,] array)
{
    Console.WriteLine();
    Console.Write("Какую строку вы ищете?: ");
    int userRowForSearching = Convert.ToInt32(Console.ReadLine());
    Console.Write("Какой столбец вы ищете?: ");
    int userColumnForSearching = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    if (userRowForSearching < array.GetLength(0) || userColumnForSearching < array.GetLength(1))
    {
        int result = 0;
        result = array[userRowForSearching, userColumnForSearching];
        Console.WriteLine($"По вашему запросу индекса в матрице найден элемент: {result}");
    }
    else 
    {
        Console.WriteLine($"Такого элемента в матрице не существует!"); /*не понимаю каким образом, 
        но иногда выходит это сообщение, а иногда программное исключение "Unhandled exception. 
        System.IndexOutOfRangeException: Index was outside the bounds of the array.". 
        Программа сама определяет, что при поиске пользователь вышел за пределы массива. Хотя, например, 
        задаю массив 5*5, ищу элемент [6,8] - показывает моё сообщение об отсутствии элемента; 
        ищу элемент [1,9] - программное исключение. В интернете читала про это, но не совсем понимаю,как это
        относится к моему решению */
    }
    Console.WriteLine();
}

