/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит 
число A в натуральную степень B.
Пример:
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
Console.WriteLine ("Введите число A: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число B: ");
int userPower = Convert.ToInt32(Console.ReadLine());

int PowerOfNumber = userNumber;

for (int i = 1; i<userPower; i++)
{
    PowerOfNumber = PowerOfNumber * userNumber;
}
Console.WriteLine ($"{userNumber} в степени {userPower} равняется {PowerOfNumber} ."); 