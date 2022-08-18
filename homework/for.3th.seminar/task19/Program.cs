/* Задача 19. Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
Пример:
14212 -> нет
12821 -> да
23432 -> да
*/
Console.WriteLine("Введите пятизначное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int firstDigit = userNumber/10000; 
int secondDigit = (userNumber/1000)%10; 
int fourthDigit = (userNumber/10)%10; 
int fifthDigit = userNumber%10; 

if (firstDigit == fifthDigit | secondDigit == fourthDigit)
{
    Console.WriteLine("Это палиндром!");
}
else 
{
    Console.WriteLine("Это не палиндром!");
}

