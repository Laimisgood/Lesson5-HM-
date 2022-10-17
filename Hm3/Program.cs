// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

double[] CreateArray(int len, int minLimit, int maxLimit)
{
    double[] array = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minLimit, maxLimit + 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

double MaxVal(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

double MinVal(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}

double Difference(double max, double min)
{
    double dif = max - min;
    return dif;
}

double[] array = CreateArray(6, 10, 100);
PrintArray(array);
double max = MaxVal(array);
double min = MinVal(array);
double dif = Difference(max, min);
System.Console.WriteLine($"Разница максимального и минимального чисел в матрице = {dif}");
