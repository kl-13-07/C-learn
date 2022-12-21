public static class MyLibrary
{
    // метод, который создаёт массив 
    public static int [] CreateArray(int count = 0)
    {
        return  new int [count];
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
}