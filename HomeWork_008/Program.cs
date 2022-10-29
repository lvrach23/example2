/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

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
void SortArrey(int[,] arrey)
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            for (int k = 0; k < arrey.GetLength(1) - 1; k++)
            {
                if (arrey[i, k] < arrey[i, k + 1])
                {
                    int temp = arrey[i, k + 1];
                    arrey[i, k + 1] = arrey[i, k];
                    arrey[i, k] = temp;
                }
            }
        }
    }
}
Console.WriteLine();
SortArrey(arrey2);

for (int i =0; i<arrey2.GetLength(0); i++ )
    {
        for (int j = 0; j<arrey2.GetLength(1); j++)
        {
            Console.Write($"{arrey2[i,j]} ");
        }
        Console.WriteLine();
    }*/

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

/*int[,] CreatArrey()
{   
    int[,] arrey = new int [5,3];
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
int[] sumLine = sumLineFunc(arrey2);

int[] sumLineFunc(int[,] arrey)
{
    int[] arr = new int[arrey.GetLength(0)];
    for (int i =0; i<arrey.GetLength(0); i++ )
    {   
        int tempSum = 0;
        for (int j = 0; j<arrey.GetLength(1); j++)
        {
            tempSum+=arrey[i,j];
            arr[i] = tempSum;
        }
            
    }
    return arr;
}

int minSumLine(int[] arrey)
{
    int min = arrey[0];
    int line = 1;
    for (int i = 0; i<arrey.Length; i++)
    {
        if (min > arrey[i])
        {   
            min = arrey[i];
            line = i + 1;
        }
    }
    return line;
}
int answer = minSumLine(sumLine);

Console.Write($"Минимальная сумма на линии:{answer}");*/

/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/


/*int[,] CreatArrey()
{   
    int[,] arrey = new int [2,2];
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

int [,] firstMatr = CreatArrey();
Console.WriteLine("---");
int [,] secondMatr = CreatArrey();
int [,] resultMatr = new int [2,2];

for (int i = 0; i < resultMatr.GetLength(0);  i++)
{
    for (int j= 0; j < resultMatr.GetLength(1); j++)
    {
        int sum = 0;
        for (int k =0; k < firstMatr.GetLength(1); k++)
        {
            sum+=firstMatr[i,k]*secondMatr[k,j];
        }
        resultMatr[i,j] = sum;
    }
}

void printArr(int[,] arrey)
{
    for (int i =0; i<arrey.GetLength(0); i++ )
        {
            for (int j = 0; j<arrey.GetLength(1); j++)
            {
                Console.Write($"{arrey[i,j]} ");
            }
            Console.WriteLine();
        }
}
Console.WriteLine();
printArr(resultMatr);*/

/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int[,] arrey = new int[4, 4];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= arrey.GetLength(0) * arrey.GetLength(1))
{
  arrey[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < arrey.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= arrey.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > arrey.GetLength(1) - 1)
    j--;
  else
    i--;
}

PrintArray(arrey);

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}