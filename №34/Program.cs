// Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.Clear();

Console.Write("Размер массива: ");
int arrayLength = int.Parse(Console.ReadLine() ?? "0");
int[] arrayOne = new int[arrayLength];

FillArray(arrayOne);
PrintArray(arrayOne);
Console.Write(EvenSum(arrayOne));


void FillArray(int[] array)
{
    Random rand = new Random();
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = rand.Next(100, 1000);
    }
}

int EvenSum(int[] array)
{
    int count = 0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (array[i] %2 == 0)
        count++;
    }
    return count;
}

void PrintArray(int[] array)
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