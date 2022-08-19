/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
Пример:
456 -> 3
78 -> 2
89126 -> 5  
*/
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());
int Counter(int num)
{
    int count = 0;
    while(count < num);
    {
        num = num/10;
        count++;
    }
    return count;
}
Console.WriteLine(Counter(num));

