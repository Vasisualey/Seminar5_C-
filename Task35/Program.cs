// Задача 35. Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат
// в отрезке 10- 99.
Console.Clear();
int[] GetArray(int length, int min, int max)
{
    int [] res = new int[length];
    for (int i =0; i<length; i++)
    {
        res[i] = new Random().Next(min, max+1);
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



int inputnumber(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine()!);
    return res;
}
int length = 123;
int maxinterval = 99;
int mininterval = 10;

int SummArrayInterval(int[] Somearray,int mininterval, int maxinterval)
{
    int sum =0;
    for(int i =0; i<Somearray.Length; i++)
    {
        if (Somearray[i] >= mininterval && Somearray[i]< maxinterval) sum++;
    }
    return sum;
}
int min = inputnumber("Введите минимальное значение в массиве");
int max = inputnumber("Введите максимальное значение в массиве");
int[] array = GetArray(length,min,max);
int sum = SummArrayInterval(array, mininterval, maxinterval);

Print(array);
Console.WriteLine($"Количество элементов в заданном отрезке = {sum}");
