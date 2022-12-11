using static MyLibrary;

Console.Write("\nВведите натуральное число : ");
int N = Convert.ToInt32(Console.ReadLine());
int a = 1;
int b = 0;



while (a <= N)
{
    b = Cube(a);
    Console.WriteLine(b);
    a++;
}


