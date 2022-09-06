/* Задача 64: Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа в промежутке от M до N от большего к меньшему.
Пример:
M = 1; N = 5. -> ""5, 4, 3, 2, 1""
M = 4; N = 8. -> ""8, 7, 6, 5, 4""
*/
Console.WriteLine();
Console.Write("Введите число M: ");
int userM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int userN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

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
Console.WriteLine($"Вывод натуральных чисел в промежутке от {userM} до {userN} от большего к меньшему: ");
Console.WriteLine(MaxToMin(userM, userN));
Console.WriteLine();