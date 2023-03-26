// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 10);
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

void ReleaseArray(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
        sum = sum + array[i]; 
        Console.Write($"Сумма элементов на нечетных позициях равна {sum}");
}

Console.Clear();
Console.Write($"Введите длину массива: n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
PrintArray(array);
ReleaseArray(array);