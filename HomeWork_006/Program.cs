//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

/*int [] creatArrey()
{
    
    Console.Write($"Введите количество чисел которые хотите ввести: ");
    int len = int.Parse(Console.ReadLine()!);
    int[] arrey = new int[len];
    for (int i=0; i<len; i++)
    {
        Console.Write($"Введите число: ");
        arrey[i] = int.Parse(Console.ReadLine()!);
    }
    return arrey;
    
}
int findPos(int[] arr)
{
    int count = 0;
    for (int i = 0; i<arr.Length; i++)
    {
        if (arr[i]>0)
            count++;
    }
    return count;
}
int[] arrey2 = creatArrey();
int answer = findPos(arrey2);
foreach (var item in arrey2)
    Console.Write($"{item}; ");
Console.Write($"->{answer}");*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//y=k1*(b2-b1)/(k1-k2)+b1
//x=(b2-b1)/(k1-k2)
//    2   0   1  3


double [] dots= new double[4];
string[] text = new string[] {"А координата b1", "А координата k1", "B координата b2", "B координата k2"};
double x; 
double y; 
for (int i=0; i<4; i++)
{
    Console.Write($"Введите точку линии {text[i]} ");
    dots[i] = double.Parse(Console.ReadLine()!);
}
x = (dots[2]-dots[0])/(dots[1]-dots[3]);
y = dots[1] * x + dots[0];

Console.Write($"{x}    {y}");
