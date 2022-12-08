

/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

using static MyLibrary;



int[] array = { 1, 2 };

PrintArray(array);

Console.WriteLine();

int size = array.Length;

if (size >= 3)
{
    Console.WriteLine(array[2]);
}
else Console.WriteLine("Третьей цифры нет!!");





















