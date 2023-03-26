// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(10, 100);
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

int[] numbers = new int[10];
FillArray(numbers);
PrintArray(numbers);
int max = numbers[0];
int min = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
 if (numbers[i] > max)
    {
 max = numbers[i];
    }
 else if (numbers[i] < min)
    {
        min = numbers[i];
    }
}

Console.WriteLine($"Разница между максимальным и минимальным числами: {max - min}");

// double[] array = new double[10];

// for (int i = 0; i < array.Length; i++)         // * (end - begin) + begin
//     array[i] = Math.Round(new Random().NextDouble() * (9 - 1) + 1, 1);  // [1; 9]

// double max1 = array[0];
// double min1 = array[0];

// for (int i = 0; i < array.Length; i++) 
// {
//     if (array[i] > max1)
//         max1 = array[i];
//     if (array[i] < min1)
//         min1 = array[i];
// }

// Console.WriteLine($"[{string.Join(", ", array)}]");
// Console.WriteLine($"Разница между максимальным и минимальным числами: {max1 - min1}");