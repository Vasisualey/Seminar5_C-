// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т д.
// Результат запишите в новом массиве
Console.Clear();
int length = inputnumber ("Введите размер массива");
int min = inputnumber ("Введите минимальное значение в массиве");
int max = inputnumber ("Введите максимальное значение в массиве");
int inputnumber(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine()!);
    return res;
}



int[] array = GetArray(length, min, max);
Print(array);

int[] GetArray(int length, int min, int max)
{
    int [] res = new int[length];
    for (int i =0; i<length; i++)
    {
        res[i] = new Random().Next(min,max);
    }
    return res;
}
int[] MultFirstlast(int[] Somearray)
{
     int oldlength = Somearray.Length;
     int newlength = (oldlength/2)+(oldlength%2);
     Console.WriteLine(newlength);
     int[] res = new int [newlength];
for (int i = 0; i < newlength; i++)
{
    if(i != (oldlength -1 -i))
    {
        res[i] = Somearray[i] * Somearray[oldlength -1 -i];
    }
    else
    {
        res[i] = Somearray[i];
    }
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
Print(MultFirstlast(array));