// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double DifferenceMaxMinMassiv(double [] array)
{
    double mux = array[0];
    double min = array[0];

    for ( int i =0; i < array.Length; i++)
    {
        if (array[i] > mux) mux = array[i];
        if (array[i] < min) min = array[i];
    }
    Console.Write($" => {mux} - {min}");
    double diff = Math.Round(mux - min, 2);
    return diff ;
}

double[] GenerateMassiv(int size, int start, int finish)
{
    double[] array = new double[size];
    
    for ( int i =0; i< array.Length; i++)
    {
        array[i] = Math.Round(new Random().Next( start, finish+1)+ new Random().NextDouble(), 2);
    }
    return array;
}

int GetInputText (string text)
{
Console.WriteLine(text);
return Convert.ToInt32(Console.ReadLine());
}

int size = GetInputText(" Введите размер массива: ");
int start = GetInputText(" Введите минимальное число массива: ");
int finish = GetInputText(" Введите максимальное число массива: ");

double [] array = GenerateMassiv(size, start, finish);

Console.Write($"[{String.Join(" ," , array)}] ");
Console.Write ($" = { DifferenceMaxMinMassiv(array)} ");