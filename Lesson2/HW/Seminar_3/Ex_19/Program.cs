
Console.Write("\nВведите натуральное число : ");
int N = Convert.ToInt32(Console.ReadLine());
int rev = 0;
int n = N;
int dig;

while (N > 0)
{
    dig = N % 10;
    rev = rev * 10 + dig;
    N = N / 10;
}


if (n == rev)
{
    Console.WriteLine("Число является палиндромом");
}
 else
{
    Console.WriteLine("Число не является палиндромом");
}
 

