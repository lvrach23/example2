# Учусь С#

__dotnet new console__ - инициализация папки для инициализации папки для с#

__Console.WriteLine("нужный текст");__ - функция выводит текст в консоль.

__Console.Write("нужный текст");__ - Функция выводит текс остается на строке.

__dotnet run__ - запускает программу

__Console.ReadLine();__ - считывает данные с консоли

> Console.Readline()!; восклицательный знак после скобок убирает предупреждения.

__int(string,duo).Parse(имя переменной которую переводим в число)__ -перевод в нужный тип данных. 

 > a=int.Parse(user);

 __(int)Math.Pow(число;степень)__- возведение в степень. возвращает тип данных double, поэтому если нужно целое число, то перед надо поставить инт. 
 
 __Math.Sqrt__-извлечение квадратного корня

 __Math.Round(переменна, до скольки знаков до запятой округляем)__ - Пример Math.Round(x, 3)

__($"{переменные} text {переменные}")__ - для Console.Write вставлять нужные перенные в текст.

__("Текст:\t")__ -\t отступ в табуляцию

__string.Join(Разделитель, имя масива)__ разделитель в кавычках указывается. Пример: string ans = string.Join(", ", answer)
__String.Format("{0:D}", array[i])__ 

__Console.ReadKey();__- приостанавливает консоль до нажатия клавиши.

## оператор ветвления

>__if (в скобках пищем условие которое должно соблюдаться)__

{
    
    тут пишем что делать если условие выполнилось.
}

__switch (x)__  конструкция проверяет условие, можно использоват вместо if и else if

{
    __case 1:__
        Console.Write($"X > 0  Y > 0");
        break;
    case 2:
        Console.Write($"X < 0  Y > 0");
        break;
    case 3:
        Console.Write($"X < 0  Y < 0");
        break;
    case 4:
        Console.Write($"X > 0  Y < 0");
        break;
    default:
        Console.Write($"Неверный ввод");
        break;__
}

## цикл
>while (условие)

{

    Тут пишем что делать + увеличение счетчика
}

>for(int i=0(счетчик); i<6(условие до выполнение которого будет крутиться цикл); i++(прибавление к счетчику после итерации))

{

    тело цикла
}

>foreach (var item in array) Конструкция помогает перебирать массив и выводить его.
{

    Console.Write($"{item} ");
}

__new Random().Next(левая граница, правая граница)__ -генирация рандомных чисел

__Console.Write(a.ToString().Remove(1,1));__ -перевод переменной а в строковую и удаление элемента с индексом 1.

__int[] array = new int [10];__ -конструкция(new int[10]) создает новый массив с 10 элементами.

__bool flag1 = int.TryParse(Console.ReadLine()!, out x);__- конструкция переводит введенные значения в формат числа(int), за это отвечает TryParse, записывает в переменную x это команда out, с помошью bool flag1 можно проверить правильность ввода.

## Функции(методы)

модификаторы тип_возвращвемого_значение название метода(параметры)
{
    тело метода
}

в sring можно записать число.
