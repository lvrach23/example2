/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

/*double[,] CreatArrey()
{   
    double[,] arrey = new double [3,4];
    for (int i =0; i<arrey.GetLength(0); i++ )
    {
        for (int j = 0; j<arrey.GetLength(1); j++)
        {
            arrey[i,j]=new Random().Next(-100, 100)/(double)10;
            Console.Write($"{arrey[i,j]} ");
        }
        Console.WriteLine();
    }
    return arrey;
}
double[,] Arr = CreatArrey();*/

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/
/*int[,] CreatArrey()
{   
    int[,] arrey = new int [3,4];
    for (int i =0; i<arrey.GetLength(0); i++ )
    {
        for (int j = 0; j<arrey.GetLength(1); j++)
        {
            arrey[i,j]=new Random().Next(10);
            Console.Write($"{arrey[i,j]} ");
        }
        Console.WriteLine();
    }
    return arrey;
}

int[,] arrey2 = CreatArrey();

int a, b;
Console.Write($"Введите номер строки: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Введите номер столбца: ");
int.TryParse(Console.ReadLine()!, out b);
if (a > arrey2.GetLength(0) || b > arrey2.GetLength(1))
    Console.Write($"Нет такого числа");
else
    Console.Write($"на этой позиции число {arrey2[a,b]}");*/

/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] CreatArrey()
{   
    int[,] arrey = new int [3,4];
    for (int i =0; i<arrey.GetLength(0); i++ )
    {
        for (int j = 0; j<arrey.GetLength(1); j++)
        {
            arrey[i,j]=new Random().Next(10);
            Console.Write($"{arrey[i,j]} ");
        }
        Console.WriteLine();
    }
    return arrey;
}

int[,] arrey2 = CreatArrey();
for (int i=0; i<arrey2.GetLength(1); i++)
{
    double sum = 0;
    for (int j = 0; j<arrey2.GetLength(0); j++)
    {
        sum+=arrey2[j,i];
    }
    Console.Write($"{Math.Round(sum/arrey2.GetLength(0), 1)}; ");
}
