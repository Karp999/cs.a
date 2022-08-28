/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
Пример:
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Clear();

Console.Write($"Введи число М(количество чисел): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[m];

void InputNumbers(int m)
{
    int i = 0;
    while (i < m)
    {
        Console.Write($"Введи {i + 1} число: ");
        massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }
}

int Comparison(int[] massiveNumbers)
{
    int count = 0;
    for (int i = 0; i < massiveNumbers.Length; i++)
    {
        if (massiveNumbers[i] > 0) count += 1;
    }
    return count;
}

InputNumbers(m);

Console.WriteLine($"Введено чисел больше 0: {Comparison(massiveNumbers)} ");




/*Console.WriteLine("Введите несколько чисел: ");
string[] userNumbers = Console.ReadLine().Split(',');
int numbers = int.Parse(userNumbers[0]);
string text = userNumbers[1].Trim();


int[] GetArray(int numbers, int userNumbers)
{
    int[] res = new int[numbers];
    for(int i=0; i<numbers; i++)
    {
        res[i] = new Random().Next(userNumbers);
    }
    return res;
}
Console.WriteLine (GetArray);

/*
int[] array = GetArray(10,0,10);
Console.WriteLine(String.Join(" ",array));
int[] array1 = new int [10];
for(int i = 0; i < array1.Length; i++)
{
    array1[i] = array[i];
}
Console.WriteLine(String.Join(" ",array1));

*/






/*

Console.WriteLine("Введите несколько чисел: ");
string[] userNumbers = Console.ReadLine().Split(',');
int numbers = int.Parse(userNumbers[0]);
string text = userNumbers[1].Trim();

int[] array = new int[numbers];
Console.WriteLine (array);

/* int userArray = 
int[] array = new int[userArray];
Console.WriteLine (array); */
