/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
Пример:
[345, 897, 568, 234] -> 2
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
Console.WriteLine(); /*эта пустая строка и пустые строки в самом низу кода для красоты и читабельности отображения,
можно и без них */

int [] ArrayThreeDigitNumbers = GetArray(10, 99, 1000);
int evenNums = 0;//для подсчёта чётных чисел

for(int i = 0; i < ArrayThreeDigitNumbers.Length; i++)
{
   if(ArrayThreeDigitNumbers[i] % 2 == 0)
    {
        evenNums = evenNums+1;
    }
}
Console.Write($" - в указанном массиве {evenNums} чётных чисел. "); 
Console.WriteLine();
Console.WriteLine();