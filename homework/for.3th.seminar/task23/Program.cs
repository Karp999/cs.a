/* Задача 23. Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
Пример:
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 
*/

Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("1");
for(int i = 2; i<=userNumber; i++) 
{
    int square = i*i;
    Console.Write($",{square}");
}


/* if i=userNumber;
    {
        Console.Write($"{square}");
    } */