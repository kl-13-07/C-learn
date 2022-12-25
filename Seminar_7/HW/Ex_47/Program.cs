using static MyLibrary;


/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
 */


/* int[,] matrix = new int[3, 5];
FillArrayX2(matrix, 1, 10);
PrintArrayX2(matrix); */

double[,] matrix = new double[2, 5];

FillRandDoubleTwo(matrix, 0,  0, true, 100000, 100, 6, true);

PrintArrayX2(matrix);
