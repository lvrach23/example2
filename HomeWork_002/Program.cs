/* Задача №1
int a = new Random().Next(100, 1000);
Console.Write($"{a} -> {( a / 10) % 10}");
*/

/*Задача №2
int a = new Random().Next();
string answer = a.ToString();
if (answer.Length > 2)
    Console.Write($"{a} -> {answer[2]}");
else 
    Console.Write($"{a} -> третьей цифры нет");
*/

//Задача №3
Console.Write("введите порядковый номер дня недели: ");
int a = int.Parse(Console.ReadLine()!);
if (a==6 || a==7)
    Console.Write($"{a} -> да");
else
    Console.Write($"{a} -> нет");
