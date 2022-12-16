
using static MyLibrary;


/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */


int [] array = CreateArray(5);

FillArray(array, 0, 10);
PrintArray(array);
int M = ChetnostSum(array);

Console.WriteLine();

Console.WriteLine(M);



