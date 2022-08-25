/*Задача 33: Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да*/

int [] GetArray(int size, int minValue, int maxValue)
{
    int [] res = new int [size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}

int [] array = GetArray(5, 0, 999);
Console.WriteLine();

Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int answer = 0;

for(int i = 0; i < array.Length; i++)
{
    if(array[i] == userNumber)
    {
        answer++;
    }
}

if(answer > 0)
{
    Console.WriteLine($"В массиве есть число {userNumber}");
}
else
{
    Console.WriteLine($"В массиве нет числа {userNumber}");
}
