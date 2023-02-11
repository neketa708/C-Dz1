Console.WriteLine("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a>b)
{
    Console.WriteLine("max "+a);
} else if(b>a)
{
    Console.WriteLine("max "+b);
} else
{
    Console.WriteLine("равны");
}