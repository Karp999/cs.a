/* Задача 23. Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
Пример:
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 
*/

Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i<=userNumber; i++) 
{
    int cube = i*i*i;
    Console.Write($"{cube} ");
}
