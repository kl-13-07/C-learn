using static MyLibrary;


/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным элементов массива.

[3 7 22 2 78] -> 76 */



int [] array = CreateArray(5);
FillArray(array, 1, 10);
PrintArray (array);


int M = SravnenieRaznitsa(array);

Console.WriteLine();
Console.WriteLine(M);






