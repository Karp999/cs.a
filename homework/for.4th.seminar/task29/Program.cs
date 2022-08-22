/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
(на примерах демонстрация выводов 5 и 3 размерных массивов, вам же нужно сделать 8):
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
int[] array = new int[8];

void FillArray(int[] digits)
{
int length = digits.Length;
    int i = 0;
    while (i<length)
    {
        digits[i] = new Random().Next(0,99); /*Рекомендации по заполнению массива отсутствуют,
        поэтому взяла один из стандартных промежутков: от 0 до 99. */
        i++;
    }
}
void PrintArray(int[] nums)
{
    int i = nums.Length;
    int position = 0; /* Это позиция элемента в массиве. Взяла на заметку из лекции, где
    лектор предложил заводить позицию не через индекс.*/
    while (position < i)
    {
        Console.Write($"{nums[position]} ");
        position++;
    }

}

FillArray(array);
PrintArray(array);