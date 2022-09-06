/* Задача 64: Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа в промежутке от M до N от большего к меньшему.
Пример:
M = 1; N = 5. -> ""5, 4, 3, 2, 1""
M = 4; N = 8. -> ""8, 7, 6, 5, 4""
*/

Console.WriteLine("Введите число M: ");
int userM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int userN = Convert.ToInt32(Console.ReadLine());

string MaxToMin(int userM, int userN)
{
    if (userM < userN)
    {
        return $"{userN} " + MaxToMin(userM, userN - 1);
    }
    else
    {
        return $"{userM} ";
    }
}
Console.WriteLine(MaxToMin(userM, userN));