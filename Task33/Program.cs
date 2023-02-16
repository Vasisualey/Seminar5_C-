// Задача 33. Задайте массив. Напишите программу, которая определяет
// присутствует ли заданное число в массиве
Console.Clear();
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

int inputnumber(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine());
    return res;
}
bool ArrayNum( int[] Somearray, int checknum)
{
    bool found = false;
for (int i = 0; i<Somearray.Length-1;i++)
    {
    if (Somearray[i] == checknum)
        {
        found = true;
        }
    }
    return found;
}
int length = inputnumber ("Введите размер массива");
int min = inputnumber ("Введите минимальное значение в массиве");
int max = inputnumber ("Введите максимальное значение в массиве");
int num = inputnumber ("Введите искомое число");



int[] array = GetArray(length, min, max);

Print(array);
if (ArrayNum(array,num)) 
{
Console.WriteLine($"Число {num} в массиве присутствует.");
}
else
{
Console.WriteLine($"Числа {num} в массиве нет.");
}



