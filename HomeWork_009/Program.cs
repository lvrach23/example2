/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" 

int N;

Console.Write($"Введите число N: ");
int.TryParse(Console.ReadLine()!, out N);


Console.Write(OutputStr(N));

string OutputStr(int numb)
{
    if (numb == 1)
        return numb.ToString() + "\n";
    return $"{numb} {OutputStr(numb-1)}"; 
}
*/

/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30


int N, M;
Console.Write($"Введите число M: ");
int.TryParse(Console.ReadLine()!, out M);
Console.Write($"Введите число N: ");
int.TryParse(Console.ReadLine()!, out N);

int Sum(int A, int B)
{
    if (A>= B)
        return A;
    return A + Sum(A+1, B );
}

Console.Write(Sum(M, N)); */

int AkkerFunc(int M, int N)
{
	if(M == 0)
	{
		return N + 1;
	}
		if(M > 0 && N == 0)
		{
			return AkkerFunc(M - 1, 1);
		}
		return AkkerFunc(M - 1, AkkerFunc(M, N - 1));
}
		
Console.WriteLine(AkkerFunc(3,2));