﻿
// КАК МОЖНО ОПРЕДЕЛИТЬ/ЗАДАТЬ МАССИВ:

int[] arr = new int[3] { 1, 2, 3 };
int[] arr = new int[] { 1, 2, 3 };
int[] arr = { 1, 2, 3 };            // САМЫЙ ПРОСТОЙ


var arr = int[]{1,2,3};  // ЕСТЬ ЕЩЕ ШТУКА ВАР, ОНА САМА ОПРЕДЕЛЯЕТ ТИП ДАННЫХ, !!! НО С МАССИВАМИ ЭТО НЕ РАБОТАЕТ!

var num = 5;        // ВОТ С ЧИСЛАМИ РАБОТАЕТ
var num1 = 5.1;

// ЗАДАЧА ИЗ КВИЗА

int[] arr = { 1, 2, 3, 4, 5 };

int i = 0;

while (i < arr.Length)
{
    arr[i] *= i * 2;
    Console.Write(arr[i++]);  // ЭТА ЗАПИСЬ ГОВОРИТ НАПЕЧАТАЙ ИТЫЙ ЭЛЕМЕНТ И ПОТОМ ПРИБАВЬ К НЕМУ 1. 
                              // ДЕЛАЕТСЯ ТАК ВМЕСТО ТОГО ЧТОБЫ ПИСАТЬ ЭТО В 2 СТРОКИ
                              // ЕСЛИ НАПИСАТЬ ++i, ТО СНАЧАЛА ПРИБАВИТ, ПОТОМ НАПЕЧАТАЕТ
}



arr[0] = arr[1] = 1 // МОЖНО ЗАПИСЫВАТЬ В ОДНУ СТРОКУ ПРИСВАИВАНИЕ ОДИНАКОГО ЗНАЧЕНИЯ