// ЛЕКЦИЯ №4. Двумерные массивы и рекурсия 

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