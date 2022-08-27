/* Задача 45: Напишите программу, которая будет создавать копию заданного массива с 
помощью поэлементного копирования.
*/


/*int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i=0; i<size; i++)
    {
        res[i] = new Random().Next(minValue,maxValue);
    }
    return res;
}
int[] array = GetArray(10,0,10);
Console.WriteLine(String.Join(" ",array));
int[] array1 = new int [10];
for(int i = 0; i < array1.Length; i++)
{
    array1[i] = array[i];
}
Console.WriteLine(String.Join(" ",array1));*/

int[] arr = new int[8]; // создали массив из восьми элементов

void RandomArray(int[] array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        //Создание объекта для генерации чисел
        Random rnd = new Random();
        //Получить случайное число 
        int value = rnd.Next(100);
        arr[i] = value;
        Console.Write($"{arr[i]} ");
    }
}

RandomArray(arr);

Console.WriteLine();

void CopiedArray(int[] arr)
{
    int[] coppiedArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        coppiedArr[i] = arr[i];
        Console.Write($"{coppiedArr[i]} ");
    }
}

CopiedArray(arr);