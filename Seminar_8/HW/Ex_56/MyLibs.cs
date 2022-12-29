public static class MyLibrary
{
    // метод, который создаёт массив 
    public static int[] CreateArray(int count = 0)
    {
        return new int[count];
    }


    /// метод, который заполняет массив 


    public static void FillArray(int[] array, int min, int max)
    {
        int size = array.Length;
        for (int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(min, max);
        }


    }


    // метод, который выводит массив


    public static void PrintArray(int[] array)
    {

        int size = array.Length;
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(array[i]);
        }

    }


    // метод, который возводит в степень


    public static int Square(int value1, int value2)

    {
        int result = 1;
        {

            for (int i = 0; i < value2; i++)

                result = result * value1;
        }
        return result;
    }




    // метод, который переводит число из одной системы исчисления  в другую

    //  [6, 1, 0, 1, 1]
    //   4  3  2  1  0

    //  0 ^ 15 * 1 + 1 ^ 15 * 1 + 2 ^ 15 * 0 + 3 ^ 15 * 1 + 4 ^ 15 * 6



    public static int ConvertToFifth(int[] value)

    {
        int result = 0;
        int count = value.Length;

        for (int i = 0; i < count; i++)


            result = result + value[i] * Square(15, count - 1 - i);




        return result;

    }


    static public int Chetnostkolichestvo(int[] array)
    {

        int size = array.Length;
        int count = 0;


        for (int i = 0; i < size; i++)
        {

            if (array[i] % 2 == 0)
            {
                count++;
            }

        }
        return count;

    }

    //метод , который проверяет на чётность и складывает чётные числа



    static public int ChetnostSum(int[] array)

    {

        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {

            if (array[i] % 2 == 0)
            {
                sum = sum + array[i];
            }

        }
        return sum;

    }

    //метод , который проверяет на чётность находит минимальное и максимальное значение и выводит их разницу

    static public int SravnenieRaznitsa(int[] array)

    {
        int size = array.Length;
        int min = size;
        int max = 0;


        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }

        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] > max)
            {
                max = array[j];
            }



        }
        int result = max - min;


        return result;
    }


    //Заполнение массива вручнвую с клавиатуры
    public static void FillArrayManual(int[] array, int arg1)
    {
        for (int i = 0; i < array.Length; i++)

        {
            Console.WriteLine($"ВВедите число для следующего индекса");

            array[i] = Convert.ToInt32(Console.ReadLine());
        }
    }





    // заполненеие двумерного массива случайными числами

    public static void FillArrayX2(int[,] matr, int min, int max)


    {

        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = new Random().Next(min, max);
            }

        }


    }


    // метод, который выводит массив


    public static void PrintArrayX2(int[,] matr)


    {

        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write($"{matr[i, j]}");

            }
            Console.WriteLine();

        }
    }

    // Заполнение рандом вещественных чисел двумерны массив
    public static void FillRandDoubleTwo(double[,] array, int minInt, int minFrac, bool minInclude, int maxInt, int maxFrac, int numOfDigits, bool maxInclude)
    {
        int size0 = array.GetLength(0);
        int size1 = array.GetLength(1);
        for (int i = 0; i < size0; i++)
        {
            for (int j = 0; j < size1; j++)
            {
                array[i, j] = Random.Shared.Next(minInclude ? minInt : minInt - 1, maxInclude ? maxInt : maxInt - 1) + (Random.Shared.Next(minFrac, maxFrac) / (Math.Pow(10, numOfDigits)));

            }
        }
    }










    // Метод, который сортирыет построчно 2мерный массив

    public static void SortMetodx2(int[,] matr)

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

                        int temporary = max;  //если следующая после позиции j первое в строке число больше чем max, то положить бывший max во временную переменную
                        max = matr[i, k];  // пложить в переменную max идущее после числа в позиции j в строке
                        matr[i, k] = temporary; // положить в следующее число после j старый max
                    }

                }

                matr[i, j] = max; // положить в позицию j новый max после прохода по всей строке




            }


        }
    }



    // Метод, который складывает все числа в строке двумерного массива и сравнивает строки и выводит строку с наименьшей суммой

    










}





