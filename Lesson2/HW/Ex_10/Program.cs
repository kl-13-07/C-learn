using static MyLibrary;



/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */



int [] array = CreateArray(3);
FillArray(array, 1, 10);
PrintArray(array);

Console.WriteLine();

Console.WriteLine(array[1]);


/* int[] array={1,2,3};

Console.WriteLine(array[1]);
 */



