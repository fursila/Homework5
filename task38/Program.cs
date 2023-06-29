Console.Clear();
double[] GetRandomArray(int size, int minValue, int maxValue)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().NextDouble() * (maxValue - minValue + 1) + minValue;
    }
    return result;
}
void Minmax(double[] array){
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }

Console.WriteLine($"минимальное значение {min:f2}");
Console.WriteLine($"максимальное значение {max:f2}");
Console.WriteLine($"разница {max - min:f2}");
}
double[] arr = GetRandomArray(5,10,100);
Console.WriteLine(String.Join(" ",arr));
Minmax(arr);