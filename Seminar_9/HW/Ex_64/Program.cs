﻿
using static MyLibrary;


/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */



Console.WriteLine("Введите число");

int A;

A = Convert.ToInt32(Console.ReadLine());


static void   NumberDoN(int N)
{
Console.Write(N);

if (N == 1) return;

else NumberDoN(N-1);

}

NumberDoN(A);