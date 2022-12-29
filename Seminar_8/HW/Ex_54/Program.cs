using static MyLibrary;


/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */


int[,] matrix = new int[3, 4];

FillArrayX2(matrix, 1, 10);



PrintArrayX2(matrix);



 static void SortMetodx2 (int[,] matr)
{

for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {

        int max = matr[i, j];


        for (int k = j + 1; k < matr.GetLength(1); k++)
        {

            if (matr[i, k] > max)

            {

                int temporary = max; 
                max = matr[i, k];
                matr[i, k] = temporary;
            }

        }

        matr[i, j] = max;




    }


}
} 

SortMetodx2(matrix);

Console.WriteLine();

PrintArrayX2(matrix);


