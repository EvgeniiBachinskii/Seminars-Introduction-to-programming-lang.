﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] GetArray(int N) // ввод метода создания заполненного массива из N элементов
{
    int[] array = new int[N]; // создание пустого массива с N количеством ячеек
    for (int i = 0; i < N; i++) //  цикл наполнения массива. Записывает в каждую ячейку рандомное число 
    {                           // пока индекс не станет равен длине массива
        array[i] = new Random().Next(0, 1000);
    }
    return array; // возвращение готового массива
}


void printArray(int[] inArray)   // метод печати имеющегося массива. На вход принимает готовый массив
{
    int i = 0;              // сразу задан счетчик индексов
    Console.Write($"[{inArray[i]},");  // чтобы первая ячейка была с [
    i++;
    while (i < inArray.Length - 1)   // далее цикл печати элементов от 2го до предпоследнего
    {
        Console.Write($"{inArray[i]},");
        i++;
    }
    Console.Write($"{inArray[i]}]");   // печать последнего элемента с ]
}

printArray(GetArray(10));    // запуск обоих функций 

// READY