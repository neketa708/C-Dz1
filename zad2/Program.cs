// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a>b && a>c)
{
    Console.WriteLine("max "+a);
} else if (b>c)
{
    Console.WriteLine("max "+b);
} else
{
    Console.WriteLine("max "+c);
}