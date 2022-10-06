// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3,21 7,04 22,93 -2,71 78,24] -> max = 78,24, min = - 2,71, difference = 80,95

Console.Clear();

Console.Write("Размер массива: ");
int arrayLength = int.Parse(Console.ReadLine() ?? "0");
double[] arrayOne = new double[arrayLength];

FillArray(arrayOne);
PrintArray(arrayOne);
Console.Write(MaxMinDiff(arrayOne));


void FillArray(double[] array)
{
    Random rand = new Random();
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = Math.Round(Convert.ToDouble(rand.Next(0, 10)) + rand.NextDouble(), 2);
    }
}

double MaxMinDiff(double[] array)
{
    int min = 0;
    int max = 0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (array[i] < array[min])
            min = i;
        if (array[i] > array[max])
            max = i;
    }
    return Math.Round(array[max]-array[min],2);
}

void PrintArray(double[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i]);
        if (i == count - 1)
            Console.WriteLine("]");
        else
            Console.Write(", ");
    }
}