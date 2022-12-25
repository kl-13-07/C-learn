using static MyLibrary;


/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет */


int[,] matrix = new int [2, 5];
FillArrayX2(matrix, 1, 10);

PrintArrayX2 (matrix);

Console.WriteLine("__________________________________________");

Console.WriteLine("\nЗадайте позицию строки, искомого элемента");

        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nЗадайте позицию столбца, искомого элемента");

        int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(matrix[number1, number2]);

//Console.WriteLine($"{matrix [number1, number2]}");

//($" в Ваше массиве {count} чисел больше чем '0' ");
