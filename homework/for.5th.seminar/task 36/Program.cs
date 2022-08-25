/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях(по индексу считаем).
Пример:
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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

int [] Array = GetArray(10, 0, 99);
Console.WriteLine();
int sum = 0;//для подсчёта суммы нечётных чисел

for(int i = 0; i < Array.Length; i++)
{
   if(i % 2 > 0)
    {
        Console.WriteLine($"Слагаемое {Array[i]}."); /*проверка чисел на правильность выбора
        к суммированию: тот ли индекс выбран программой */
        sum = sum + Array[i];
        Console.WriteLine($"Промежуточная сумма {sum}.");//проверка суммы поэтапно в цикле
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях, равна: {sum} ."); 
Console.WriteLine();
Console.WriteLine();