public static class MyLibrary
{
    // метод, который создаёт массив 
    public static int[] CreateArray(int count)
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


    // метод, который проверяет число на чётность и возвращает колличество чётных чисел

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

  








}


