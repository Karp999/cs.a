/* Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли 
существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/
int a, b, c;
Console.WriteLine("Введите длину стороны a: ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите длину стороны b: ");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите длину стороны c: ");
c = Convert.ToInt32(Console.ReadLine());

string result;
result = Result(a, b, c);
Console.WriteLine(result);

string Result (int a, int b, int c)
{
    string result = string.Empty;
    if (a < (b + c) && b < (a + c) && c < (b + a))
    {
        result = "Такой треугольник имеет право на жизнь";
    }
    else
    {
        result = "Такой треугольник не существует";
    }
    return result;
}

/* ИЛИ

Console.WriteLine("Введите длину первой стороны треугольника: ");
int firstSide = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите длину второй стороны треугольника: ");
int secondSide = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите длину третьей стороны треугольника: ");
int thirdSide = Convert.ToInt32(Console.ReadLine());

if(firstSide + secondSide > thirdSide && firstSide + thirdSide > secondSide && secondSide + thirdSide > firstSide)
{
    Console.WriteLine($"Треугольник со сторонами {firstSide}, {secondSide}, {thirdSide} существует");
}
else
{
     Console.WriteLine($"Треугольника со сторонами {firstSide}, {secondSide}, {thirdSide} НЕ существует");
}
*/

/* ИЛИ

int userNumberOne = new int();
int userNumberTwo = new int();
int userNumberThree = new int();

Console.WriteLine("Введите первое число: ");
userNumberOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число число: ");
userNumberTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число число: ");
userNumberThree = Convert.ToInt32(Console.ReadLine());

void GetTriangle(int a, int b, int c)
{

if (userNumberOne < userNumberTwo + userNumberThree && userNumberTwo < userNumberOne + userNumberThree && userNumberThree < userNumberOne + userNumberTwo)
{
Console.Write("Треугольник может существовать!");
}
else
{
Console.Write("Не треугольник!");
}
}

GetTriangle(userNumberOne, userNumberTwo, userNumberThree);


*/