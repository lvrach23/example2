/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет 12821 -> да 23432 -> да

Console.Write($"введите пятизначное число: ");
string number = Console.ReadLine()!;
if (number.Length>5 || number.Length < 5)
    Console.Write($"Неверный ввод");
else if (number[0]==number[4] && number[1]==number[3])
    Console.Write($"{number} -> да");
else
    Console.Write($"{number} -> нет");
*/

/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84  A (7,-5, 0); B (1,-1,9) -> 11.53

int[] dotA = new int[3];
int[] dotB = new int[3];
string axes = "XYZ";

for (int i=0; i < 3; i++)
{
    Console.Write($"Введите {axes[i]} точки А: ");
    dotA[i]=int.Parse(Console.ReadLine()!);
}

for (int i=0; i < 3; i++)
{
    Console.Write($"Введите {axes[i]} точки B: ");
    dotB[i]=int.Parse(Console.ReadLine()!);
}

int x = (int)Math.Pow(dotA[0] - dotB[0], 2);
int y = (int)Math.Pow(dotA[1] - dotB[1], 2);
int z = (int)Math.Pow(dotA[2] - dotB[2], 2);
double ans = Math.Sqrt(x + y +z);
Console.Write($"растояние между точкой A и B равно {ans}");*/

/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27       5 -> 1, 8, 27, 64, 125

Console.Write($"Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int[] answer = new int[number];
for (int i=0; i<number; i++)
{
    answer[i]=(int)Math.Pow((i+1), 3);
}    
string ans = string.Join(", ", answer);
Console.Write($"{number} -> {ans}");*/

/*int[] creatArray()
{
    int[] array = new int[8];
    for (int i=0; i<8; i++)
        array[i]=new Random().Next(0,2);
    return array;
}*/



