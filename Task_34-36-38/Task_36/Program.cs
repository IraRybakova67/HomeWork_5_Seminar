/// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int CountEvenIndex (int[] array)
{
   int sum =0;
   for (int i = 1; i< array.Length; i = i+2) 
   {
        sum =  sum + array[i];
   }
   return sum;
}


int [] GenerateMassiv( int size, int start, int finish)
{
    int[] array = new int[ size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next( start, finish +1);
    }  
    return array;
}

int GetInput (string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32 (Console.ReadLine());
}
int size = GetInput(" Введите размер массива: ");
int start = GetInput(" Введите минимальное число массива: ");
int finish = GetInput(" Введите максимальное число массива: ");

int [] array = GenerateMassiv( size, start, finish);

int sum = CountEvenIndex (array);
Console.Write($"[{String.Join(" ," , array)}] -> {sum}");

