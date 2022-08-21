/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
(на примерах демонстрация выводов 5 и 3 размерных массивов, вам же нужно сделать 8):
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] arr = new int[8];



/*ПРИМЕРЫ:
int[] arr = new int[8];

for(int i=0; i < arr.Length; i++) {
    arr[i] = new Random().Next(0,2);
}

for(int i=0; i < arr.Length; i++) {
    Console.Write($"{arr[i]} ");
}

/*или варианты:

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

int [] array = new int[8];

FillArray(array);
PrintArray(array); */
