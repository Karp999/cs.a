/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит 
число A в натуральную степень B.
Пример:
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine ("Введите число 1: ");
double userNum1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число 2: ");
double userNum2 = Convert.ToInt32(Console.ReadLine());
//нужен цикл!!!+думай насчёт double
double result = Math.Pow(userNum1, userNum2);

Console.WriteLine ($"{userNum1} в степени {userNum2} равняется {result} .");