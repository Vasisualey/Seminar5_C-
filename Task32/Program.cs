// Задача 32: Напишите программу замены элементов массива положите
// ные элементы замените на соответствующие отрицательные и наоборот.

int[] GetArray(int length, int min, int max)
{
    int [] res = new int[length];
    for (int i =0; i<length; i++)
    {
        res[i] = new Random().Next(min,max);
    }
    return res;
}
int[] Change(int[] Somearray)
{
    int[] res = Somearray;
    for (int i = 0; i< res.Length; i++) res[i] *= -1;
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
}

int inputnumber(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine());
    return res;
}

int length = inputnumber ("Введите размер массива: ");
int min = inputnumber ("Введите минимальное значение в массиве: ");
int max = inputnumber ("Введите максимальное значение в массиве: ");

int[] array = GetArray(length, min, max);

Print(array);
array = Change(array);
Print(array);

