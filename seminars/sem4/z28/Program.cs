/*Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
Пример:
4 -> 24
5 -> 120
*/
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());  
/*Можно написать int num = int.Parse(Console.ReadLine()); !!!НО у меня показывает 
предостережение-ошибку:Возможно, аргумент-ссылка, допускающий значение NULL,
для параметра "s" в "int int.Parse(string s)", так что пишу через CONVERT */
int GetMultiply(int number) 
{   int mul = 1;    
    int i = 1;    
    while(i<=number)     
    {         
        mul *=i;        
        Console.Write($"{mul} ");         
        i++;     
    }    
    return mul; 
} 
Console.WriteLine($"Произведение чисел от 1 до А = {GetMultiply(num)}");