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






/*

//Задаем случайное количество строк и столбцов (для интереса)
int rows = new Random().Next(1,10);
int columns = new Random().Next(1,10);

//Применяем методы по созданию и печати массива, чтобы его было сразу видно
int[,] array = GetArray(rows, columns, 0, 20);
PrintArray(array);

Console.WriteLine("Введите номер строки искомого элемента массива:");
int rowNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца искомого элемента массива:");
int columnNumber = Convert.ToInt32(Console.ReadLine());

//Применяем метод по нахождению элемента
int result = GetItem(array, rowNumber, columnNumber);
//Не забываем, что индексы начинаются с нуля
//Выводим результат
if(result >= 0)
    {
        Console.WriteLine($"Элемент с индексом ({rowNumber},{columnNumber}) равен {array[rowNumber,columnNumber]}");
    }
    else
    {
        Console.WriteLine($"Элемента с индексом ({rowNumber},{columnNumber}) не существует в указанном выше массиве");
    }

//Задаем метод для заполнения массива случайными числами 
int [,] GetArray(int rows, int columns, int min, int max)
{
    int [,] result = new int [rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            result [i,j] = new Random().Next(min,max);
        }
    }
    return result;
}

//Задаем метод для вывода массива на экран

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

//Задаем метод для нахождения элемента по индексу
//Немножко изменим, так как в задании сказано про возвращаемый результат
int GetItem (int[,] array, int rowNumber, int columnNumber)
{
    int result = 0;
    if(rowNumber < array.GetLength(0) && columnNumber < array.GetLength(1))
    {
        result = array[rowNumber,columnNumber];
    }
    else
    {
        result = -1;//Будем считать, что если результат отрицательный, то такого элемента не существует
    }
    return result;
}

*/