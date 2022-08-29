/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Пример:
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.WriteLine();
Console.Write("Укажите, сколько чисел вы будете вводить:");
int userArraySize = Convert.ToInt32(Console.ReadLine());
int[] userArray = new int[userArraySize];
Console.WriteLine();

for(int i=0; i<userArraySize; i++)
{
    {
        Console.Write($"Введите число: ");
        userArray[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int ZeroOrNot (int[] userArray)
{
    int k = 0;
    for (int i = 0; i < userArraySize; i++)
    {
        if (0 < userArray[i]) 
        k++;
    }
    return k;
}
Console.WriteLine();
Console.WriteLine($"Количество чисел больше нуля: {ZeroOrNot(userArray)} .");
Console.WriteLine();
