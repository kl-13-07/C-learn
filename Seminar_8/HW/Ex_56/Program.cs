using static MyLibrary;



/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */



int[,] matrix1 = new int[3, 4];

FillArrayX2(matrix1, 1, 10);


int[] Sum1 = CreateArray(matrix1.GetLength(0));
int minindex1 = 0;
int min1 = 0;

PrintArrayX2(matrix1);
Console.WriteLine("Прямоугольный двумерный массив");
Console.WriteLine("________________________________________________________________________");


static void Sumstringx2(int[,] matrix, int[] Sum, int min, int minindex)
{

    for (int i = 0; i < matrix.GetLength(0); i++)

    {


        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Sum[i] += matrix[i, j];








        }
    }

}



Sumstringx2(matrix1, Sum1, min1, minindex1);

static int CheckMinInArray(int[] Sum, int min, int minindex)
{

    for (int k = 0; k < Sum.Length; k++)
    {

        if (k == 0)
        {
            min = Sum[k];

            minindex = 0;
        }
        else
        {
            if (Sum[k] < min)
            {
                               
                minindex = k;
            }
        }
    }
    return minindex;
}

PrintArray(Sum1);
minindex1 = CheckMinInArray(Sum1, min1, minindex1);

Console.WriteLine("Суммы элементов в строках");
Console.WriteLine("________________________________________________________________________");

Console.WriteLine($"Номер строки с наименьшей суммой элементов : {minindex1}");










