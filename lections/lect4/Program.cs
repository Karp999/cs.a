// ЛЕКЦИЯ №4. Двумерные массивы и рекурсия 

/* Пример массива из строк:
string[,] table = new string[2, 5];
table[1, 2] = "слово";
//обращение к нужному элементу массива: table[1,2]
//создаём таблицу циклом в цикле,где rows-строки, columns-столбцы
for (int rows=0; rows<2; rows++)
{
    for (int columns=0; columns<5; columns++)
    {
        Console.WriteLine($"-{table[rows,columns]}-");
    }
}
*/

/*Пример массива из чисел:
int[,] matrix = new int[3,4];
//Здесь Сергей сказал, что rows в числовом виде часто пишут i, columns - j
for (int i=0; i<matrix.GetLength(0); i++)
//в циклах или методах вместо 3 и 4,где  i<3 и j<4, мы можем указать matrix.GetLength(0)
{
    for (int j=0; j<matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i,j]}");
        /*здесь была ошибка:вывод в 1 столбец,так как Console.WriteLine($"{matrix[i,j]}")-мы каждый раз 
        переходили на новую строку.теперь мы остаёмся на строке, а потом в основной цикл добавим пустую строку
    }
    Console.WriteLine();
}
*/

//Метод, печатающий матрицу на экран и заполняющий её числами:

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
             Console.Write($"{matr[i, j]}");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10); //[1;10)-полуинтервал,несмотря на то, что скобки круглые
        }
    }
}

int[,] matrix = new int[3, 4];

Console.WriteLine();
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();

