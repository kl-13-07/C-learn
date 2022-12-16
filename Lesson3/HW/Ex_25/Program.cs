using static MyLibrary;


/* 
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ Math.Pow */


/* Console.WriteLine("Введите Ваше число, которое нужно возвести в степень!");

int A;

A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Ваше число в степень, которого нужно возвести Ваше число!");

int B;

int C = A;

B = Convert.ToInt32(Console.ReadLine());


for (int i = 2; i <=B; i++)
{

    A = A * C;

}

Console.WriteLine($"Ваше заветное число!  {A}"); */


Console.WriteLine("Введите Ваше число, которое нужно возвести в степень!");

int A;

A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Ваше число в степень, которого нужно возвести Ваше число!");

int B;

B = Convert.ToInt32(Console.ReadLine());

int result = Square (A,B);




Console.WriteLine($"Ваше заветное число!  {result}");










