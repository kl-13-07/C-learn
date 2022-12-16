using static MyLibrary;

/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве. */



int [] array = CreateArray(10);
FillArray(array, 100, 300);
PrintArray (array);


int result = Chetnostkolichestvo(array);




Console.WriteLine ();

Console.WriteLine (result);

