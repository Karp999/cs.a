/* Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в 
случайном порядке. Пример:
[1,0,1,1,0,1,0,0]
*/

int [] array = new int[8];

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(0, 2);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }

}

FillArray(array);
PrintArray(array);

/*
Или так:

int[] arr = new int[8]; // создали массив из восьми элементов

void RandomArray(int[] array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        //Создание объекта для генерации чисел
        Random rnd = new Random();
        //Получить случайное число (в диапазоне от 0 до 10)
        int value = rnd.Next(0, 2);
        arr[i] = value;
        Console.Write($"{arr[i]} ");
    }
}
RandomArray(arr);
*/
