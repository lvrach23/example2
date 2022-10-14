/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.*/
//Вариант решения 1
/*int task25(int a, int b)
{
    int ans = 1; 
    for(int i=0; i<b; i++)
        ans*=a;
    return ans;
}

int a, b;
Console.Write($"Введите число А: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"введите число B: ");
int.TryParse(Console.ReadLine()!, out b);
Console.Write($"{a} в степени {b} равно {task25(a,b)}");*/

//Вариант решения 2(почему то сначало прочитав задача решил что числа нужно вводить через цикл, получилось такое решение)
/*int[] array = new int[2];
int answer = 1;
for (int i = 0; i < 2; i++)
{   
    string number = "AB";
    Console.Write($"Введите число {number[i]}: ");
    array[i] = int.Parse(Console.ReadLine()!);
    for (int j=0; j<array[1]; j++)
    {
     answer *= array[0];
     }
}
Console.Write($"{array[0]} в степени {array[1]} равно {answer}"); */

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*int task27(int a)
{
    int ans = 0;
    while(a!=0)
    {
        ans+=a%10;
        a=a/10;
    }
    return ans;
}
int number;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out number);
Console.Write($"сумма цифр в числе {number} равна {task27(number)}");*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] creatArray()
{
    int[] array = new int[8];
    for (int i=0; i<8; i++)
        array[i]=new Random().Next(0,10);
    return array;
}

string printArray(int[] array)
{
    string result = "";
    for (int i=0; i<array.Length; i++)
        result+=array[i];
    return result;
}
int[] arr = creatArray();
string res = printArray(arr);
Console.Write(res);


    
