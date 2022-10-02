/*Задача №1
Console.Write($"Введите число 1: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write($"Введите число 2: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write($"max = {Math.Max(a,b)}");
*/

/*Задача №2
Console.Write($"Введите число 1: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write($"Введите число 2: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write($"Введите число 3: ");
int c = int.Parse(Console.ReadLine()!);
Console.Write(Math.Max(a, Math.Max(b,c)));
*/

/*Задача №3
Console.Write($"введите число: ");
int a = int.Parse(Console.ReadLine()!);
if (a % 2==0)
{
    Console.Write($"Число {a} четное"); 
}
else
{
    Console.Write($"Число {a} нечетное");
}
*/

//Задача №4
Console.Write($"Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int i = 1;
while (i<=a)
{
    if (i%2==0)
    {
        Console.Write($" {i}");
        i++;
    }
    else
    {
        i++;
    }
}
