using static MyLibrary;





Console.WriteLine("Введите длину массива");
int size;
size = Convert.ToInt32(Console.ReadLine()) -1;

int [] array =  CreateArray (size);
FillArray(array, 1, 3);
PrintArray(array);




