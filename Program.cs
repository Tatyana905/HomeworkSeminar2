// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
/*
Console.Write("Введите трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >=100 && num < 1000)
{
    int result1 = num / 10;
    int result2 = result1 % 10;
    Console.WriteLine($"Вторая цифра в числе {num} - это {result2}");
}
else Console.WriteLine("Это не трехзначное число, повторите ввод");
*/


// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
/*
string number = Console.ReadLine();
if (number.Length >= 3) Console.WriteLine($"Третья цифра в числе {number} - это {number[2]}");
else Console.WriteLine("Третьей цифры нет");
*/

// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру от 1 до 7  - ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 1 && num <= 5) Console.WriteLine("Нет");
if (num >= 6 && num <= 7) Console.WriteLine("Да");
if (num > 7 ) Console.WriteLine("Не в диапазоне от 1 до 7, повторите ввод");