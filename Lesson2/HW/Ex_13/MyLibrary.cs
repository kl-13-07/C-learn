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
           Console.WriteLine(array[i]);;
        }

    }



   

    
    
     


}