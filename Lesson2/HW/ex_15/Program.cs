






/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6, 7 - выходной.
НО дня с индексом 0 или 12 не существует.

6 -> да
7 -> да
1 -> нет */




int Monday = 1;
int Tuesday = 2;
int Wednesday = 3;
int Thursday = 4;
int Friday = 5;
int Saturday = 6;
int Sunday = 7;


Console.WriteLine("Введите ваше Ваше число и скажу что Вам сегодня делать!");
int number;
number = Convert.ToInt32(Console.ReadLine());
if (number >= 6)
    Console.WriteLine("Выходной!!! Чилим!!!");
else 
{
    Console.WriteLine("Будень! Иди на работу!");
}



