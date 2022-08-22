/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Пример:
452 -> 11
82 -> 10
9012 -> 12
*/
Console.WriteLine ("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int length = userNumber.ToString().Length; //длина числа
int digit = userNumber; //переменная для разбивки на отдельные цифры введённого числа в цикле
int sumOfDigits = 0; //сумма(первоначально =0)

for (int i=0; i<length; i++)
{
   sumOfDigits = sumOfDigits + digit%10;
   digit = digit/10;
}
Console.WriteLine($"Сумма цифр в числе {userNumber} равна {sumOfDigits} .");