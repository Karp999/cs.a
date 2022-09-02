/*Задача 65: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/

Console.WriteLine("Введите число M: ");
int firstUserNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int secondUserNumber = Convert.ToInt32(Console.ReadLine());

string NumbersRec(int firstUserNumber, int secondUserNumber)
{
    if(firstUserNumber < secondUserNumber)
    { 
        return $"{firstUserNumber} " + NumbersRec(firstUserNumber + 1, secondUserNumber);
    }
    else
    { 
        return $"{secondUserNumber} ";
    }
}

Console.WriteLine(NumbersRec(firstUserNumber, secondUserNumber));