﻿

/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */




 Console.Write("\nВведите натуральное число : "); 
int N = Convert.ToInt32(Console.ReadLine());

if (N >= 100) {
    Console.WriteLine($"Третья цифра числа {N} = {N /100}");
}
else 
{
    Console.WriteLine($"Третьей цифры в числе {N} нет\n");
} 



/* int a = 1245;
int[] array;
int size = 3;





int o = a % 10;
a = a / 10;
for (int i = 0; i < size; i++)

{
    array[i] = i;
}


.

 */






















