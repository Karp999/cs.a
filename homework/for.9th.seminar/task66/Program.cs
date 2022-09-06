/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму чётных чисел натуральных элементов в промежутке от M до N.
Пример:
M = 1; N = 15 -> 56
M = 4; N = 8. -> 18
*/

Console.WriteLine();
Console.Write("Введите число M: ");
int userM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int userN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int SumOfEvenNumbers(int userM, int userN)
{
    if (userM <= userN)
    {
        if (userM % 2 == 0)
        {
            return userM + SumOfEvenNumbers(userM + 2, userN);
        }
        else
        {
            userM = userM + 1;
            return userM + SumOfEvenNumbers(userM + 2, userN);
        }
    }
    else return 0;
}
Console.WriteLine($"Сумма чётных чисел в промежутке от {userM} до {userN} равна: {SumOfEvenNumbers(userM, userN)} . ");
Console.WriteLine();