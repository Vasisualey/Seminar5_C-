// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

// методы
int[] GetArray(int length, int min, int max)
{
    int [] res = new int[length];
    for (int i =0; i<length; i++)
    {
        res[i] = new Random().Next(min,max);
    }
    return res;
}


