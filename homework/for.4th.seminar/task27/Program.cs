/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Пример:
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine ("Введите число 1: ");
int userNum1 = Convert.ToInt32(Console.ReadLine());
int length = userNum1.ToString().Length;
Console.WriteLine ($"длина - {length}");
int sumDigit = 0;
for (int i=0; i<length; i++)
{
 
   sumDigit = sumDigit + userNum1%10;
   int digit = userNum1/10;
   Console.WriteLine ($"сумма - {sumDigit}");
   Console.WriteLine ($"следующее число - {digit}");
   //проблема с числом -отредачить
}
Console.WriteLine($"Сумма цифр в числе {userNum1} равна {sumDigit} .");


/* пример:
Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int number = userNumber;
while(number > 0)
{
    sum = sum + number % 10;
    number = number / 10;
    Console.WriteLine(sum);
}
*/
