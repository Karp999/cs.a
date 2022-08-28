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
    while (0 < num)
    {
        num = num / 10;
        count++;
    }
    return count;
}
Console.WriteLine(Counter(num));

/*
//Вариант 1.

Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string gg = Convert.ToString(num);
for (int i = 0; i < gg.Length; i++)
{
    Console.WriteLine(i);
}


//Вариант №2 
Console.Clear(); 
Console.Write("Введите число:"); 
int num = Convert.ToInt32(Console.ReadLine());  
Console.WriteLine($"Число {num} имеет {num.ToString().Length} цифр(ы)");  


//Вариант №3 
Console.Clear(); 
Console.WriteLine("Введите число: "); 
int userNumber = Convert.ToInt32(Console.ReadLine()); 
int num = userNumber; 
int i = 1;  
while(num > 9) 
{     
   num = num / 10;     
   i++; 
}  
Console.WriteLine($"В числе {userNumber} {i} цифры."); 
*/