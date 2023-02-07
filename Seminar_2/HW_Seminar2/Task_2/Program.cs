﻿// // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

Console.WriteLine("Введите число: ");

int N = int.Parse(Console.ReadLine()!);

if (N >= 1000 || N <= -1000)
{
    while (N >= 1000 || N <= -1000)
    {
        N = N / 10;
    }
    Console.WriteLine($"Третья цифра числа: {N % 10}");
}
else
{
    if (N >= 100 || N <= -100)
    {
        Console.WriteLine($"Третья цифра числа: {N % 10}");
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}


//READY




