﻿/*Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

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

int [] array = GetArray(123, 0, 999);
Console.WriteLine();

int answer = 0;

for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 9 && array[i] < 100)
    {
        answer++;
        Console.Write($"{array[i]} ");
    }
}

Console.WriteLine($"В массиве {answer} элементов в отрезке [10, 99]");


/*

int[] arr = new int[20]; // создали массив из восьми элементов

void RandomArray(int[] array)
{
for (int i = 0; i < arr.Length; i++)
{
//Создание объекта для генерации чисел
Random rnd = new Random();
//Получить случайное число
int value = rnd.Next(1000);
arr[i] = value;
Console.Write($"{arr[i]} ");
}
}

void IsNumInArray(int[] array)
{
int numExist = 0;
for (int i = 0; i < arr.Length; i++)
{
if (arr[i] > 10 && arr[i] < 99)
{
numExist++;
}
}
if (numExist > 0)
{
Console.WriteLine($"Количество чисел - {numExist}");
}
else
{
Console.WriteLine($"Чисел нет - {numExist}");
}
}

RandomArray(arr);
IsNumInArray(arr);

*/