// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

// 
int length = inputnumber("Введите количество элементов в массиве");
int min = 100;
int max = 1000;
int inputnumber(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine()!);
    return res;
}

int[] GetArray(int length, int min, int max)
{
    int [] res = new int[length];
    for (int i =0; i<length; i++)
    {
        res[i] = new Random().Next(min,max);
    }
    return res;
}
void Print(int[] Somearray)
{
    Console.Write("[");
    for(int i = 0; i<Somearray.Length-1;i++)
    {
        Console.Write($"{Somearray[i]}, ");
    }
        Console.Write($"{Somearray[Somearray.Length-1]}");
    Console.Write("]");
    Console.WriteLine();
}
int[] array = GetArray(length,min,max);
Print(array);

int quantity(int[] Somearray)
{
    int sum =0;
    for(int i =0; i<Somearray.Length; i++)
    {
        if (Somearray[i]%2 == 0) sum++;
    }
    return sum;
}
int sum = quantity(array);
Console.WriteLine($"Количество четных элементов в массиве = {sum}");
