


/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


Console.WriteLine("Введите число M");
int M;
M = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите число N");
int N;
N = Convert.ToInt32(Console.ReadLine());




  static int Sum(int valueN, int valueM)
    {
        if (valueN >= valueM )
        {
          return valueN + Sum(valueN - 1, valueM);
        }
        else
        {
            return 0;
        }
    }



Console.WriteLine(Sum(N, M));





