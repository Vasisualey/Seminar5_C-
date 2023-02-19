// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] GetArray(int length)
{
    int [] res = new int[length];
    for (int i =0; i<length; i++)
    {
        res[i] = new Random().Next();
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
int length = inputnumber ("Введите размер массива");
int[] array = GetArray(length);

int[] Sort(int [] array, int length)
{
    while(length == length-1)
	{
		for(int i = 0; i < length; i++)
		{
			if(array[i] > array[i + 1])
			{
				int temp=array[i];
                array[i]=array[i + 1];
                array[i + 1] = temp;
			}
		}
	}
    return array;
}

Print(array);
Sort(array, length);
int diff = array[length-1] - array[0];
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {diff}.");