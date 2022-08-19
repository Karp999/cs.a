/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
Пример:
456 -> 3
78 -> 2
89126 -> 5  
*/
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());  
/*Можно написать int num = int.Parse(Console.ReadLine()); !!!НО у меня показывает 
предостережение-ошибку:Возможно, аргумент-ссылка, допускающий значение NULL,
для параметра "s" в "int int.Parse(string s)", так что пишу через CONVERT */
int Counter(int num)
{
    int count = 0;
    while(0 < num)
    {
        num = num/10;
        count++;
    }
    return count;
}
Console.WriteLine(Counter(num));

