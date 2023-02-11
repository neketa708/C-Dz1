// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число : ");
int a = Convert.ToInt32(Console.ReadLine());
if (a<0)
{
    a=-a;
} 
int znac = a % 2;
if (znac==0)
{
    Console.WriteLine("четное");
} else if (znac==1)
{
    Console.WriteLine("не четное");
}
