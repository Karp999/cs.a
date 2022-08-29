/* Задача 39: Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
Пример: 
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/
Console.Clear();
int[] array = GetArray(10,0,10);
Console.WriteLine(String.Join(" ",array)); /* присоединяет к строке массив. 
вместо PrintArray можно использовать для вывода*/
int[] reversArray = ReversArray(array);
Console.WriteLine(String.Join(" ",reversArray));


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i=0; i<size; i++)
    {
        res[i] = new Random().Next(minValue,maxValue);
    }
    return res;
}

int[] ReversArray(int[] inArray)
{
    int[] result = new int[inArray.Length];//т.к.не знаем размер,пишем размер внутреннего массива
    for(int i = 0; i<inArray.Length;i++)
    {
        result[i] = inArray[inArray.Length -1 -i];//вычтем длину и вычтем i-тое, поэтому пойдет с конца
    }
    return result;
}


/*просьба ввести несколько чисел:

Console.WriteLine("Укажите, сколько чисел вы будете вводить:");
int userArraySize = Convert.ToInt32(Console.ReadLine());
int[] userArray = new int[userArraySize];

for(int i=0; i<userArraySize; i++)
{
    {
        Console.Write($"Введи {i + 1} число: ");
        userArray[i] = Convert.ToInt32(Console.ReadLine());
    }
}

*/