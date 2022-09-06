/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.(необязательная)
m = 2, n = 3 -> A(m,n) = 9
*/

/* Не до конца поняла, что такое функция Аккермана.
Нашла в интернете общие условия определения функции:
- при m=0, n>0 функция равна n+1 ;
- при m>0, n=0 функция равна A(m-1,1) ;
- при m>0, n>0 функция равна A(m-1,A(m,n-1)).
Подставила их в if, и , так как в описании функции говорится, 
что "функция принимает два неотрицательных целых числа 
в качестве параметров и возвращает натуральное число", 
то при вводе m<0 и/или n<0 вывожу ошибку.
*/

Console.WriteLine();
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int AckermannFunction(int m, int n)
{
    if ((m == 0) && (n > 0))
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return AckermannFunction(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
    else return 404; // взяла код ошибки http "Not Found": 404 :)
}

Console.Write($"Функция Аккермана равна: {AckermannFunction(m, n)} . ");
Console.WriteLine();
Console.WriteLine();