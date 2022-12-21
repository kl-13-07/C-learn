using static MyLibrary;


/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */




/* int count = 0;
int number;


System.ConsoleKey key = default(ConsoleKey);
Console.Clear();

while (true)
{
    if (key != ConsoleKey.Q)

    {
        Console.Write("\nВведите  число или введите Q для того, что бы подсчитать колличество чисел больше 0 из введённых чисел ");

        number = Convert.ToInt32(Console.ReadLine());
        key = System.Console.ReadKey(true).Key;

        if (number > 0)
        {
            count++;
        }
        Console.WriteLine($"колличество чисел больше чем 0 ------> {count}");
    }
    else break;

}
 */




Console.WriteLine("Введите длину массива");
int size;
int count = 0;
size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(("_____________________________________________________________"));


int[] array = CreateArray(size);

FillArrayManual(array, size);
Console.WriteLine("_____________________________________________________________");


PrintArray(array);

for (int i = 0; i < array.Length; i++)
{
    if (array[i]  > 0)
    {
        count++;

    }

   


}

 Console.WriteLine($" в Ваше массиве {count} чисел больше чем '0' ");





