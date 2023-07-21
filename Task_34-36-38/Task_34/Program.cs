// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int CountEvenNumbers(int [] array)
{
    int count = 0;
    for (int i =0; i < array.Length; i++)
    {
        if (array[i] %2 ==0) count++;
    }
    return count;
}

int [] FillArray(int size, int start, int finish)
{
    int [] array = new int [size];
    for ( int i = 0; i < array.Length ; i++)
    {
        array [i] = new Random ().Next (start, finish);
    }
    return array;
}

int GetInput (string text)
{
Console.WriteLine(text);
return Convert.ToInt32(Console.ReadLine());
}

int size = GetInput(" Введите размер массива: ");
int start = GetInput(" Введите минимальное число массива: ");
int finish = GetInput(" Введите максимальное число массива: ");

int [] array = FillArray(size, start, finish);

int count = CountEvenNumbers(array);

Console.WriteLine($"[{String.Join(", " , array)}] " + " -> " + count );

