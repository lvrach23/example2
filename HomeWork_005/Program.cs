/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2


int[] creatArray()
{
    int[] array = new int[4];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
    return array;
}

int[] array2 = creatArray();

int counter(int[] array)
{
    int count = 0;
    foreach (var item in array2)
    {
        Console.Write($"{item} ");
        if (item % 2 == 0)
            count++;
        
    }return count;
}
Console.Write($"{counter(array2)} положительных числа");*/

/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] creatArrey()
{
    int[] arrey = new int[9];
    for (int i = 0; i<arrey.Length; i++)
        arrey[i] = new Random().Next(10); 
    return arrey;
}


int summa(int[] arrey)
{
    int sum = 0;
    foreach (var item in arrey)
    Console.Write($"{item} ");
    for (int i = 1; i< arrey.Length; i+=2)
    {
        sum+=arrey[i];
    }
    return sum;
}

int[] arrey2 = creatArrey();

Console.Write($"Сумма нечетных позиций равно {summa(arrey2)}");*/

 /*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

int[] creatArrey()
{
    int[] arrey = new int[8];
    for (int i=0; i<arrey.Length; i++)
        arrey[i] = new Random().Next(100);
    return arrey;
}

int[] arr=creatArrey();
foreach (var item in arr)
    Console.Write($"{item} ");
int Max(int[] arrey)
{
    int max = arrey[0];
    for (int i = 0; i<arrey.Length; i++)
    {
        if (max < arrey[i])
            max = arrey[i];
    }
    return max;
}

int Min(int[] arrey)
{
    int min = arrey[0];
    for (int i = 0; i<arrey.Length; i++)
    {
        if (min > arrey[i])
            min = arrey[i];
    }
    return min;
}
int ans = Max(arr)-Min(arr);
Console.WriteLine($"-> {ans}");