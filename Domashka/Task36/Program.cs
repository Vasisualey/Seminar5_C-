// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int summ(int[] Somearray)
{
    int sum =0;
    for(int i =0; i<Somearray.Length; i++)
    {
        if (i%2 == 1) sum = sum + Somearray[i];
    }
    return sum;
}
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
        res[i] = new Random().Next(min,max+1);
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
int length = inputnumber("Введите количество элементов в массиве");
int min = inputnumber("Введите минимальное значение в массиве");
int max = inputnumber("Введите максимальное значение в массиве");
int[] array = GetArray(length,min,max);
Print(array);


int sum = summ(array);
Console.WriteLine($"Сумма нечетных элементов в массиве = {sum}.");


