// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.Write("Введите число: ");
int N = Convert.ToInt16(Console.ReadLine());
int i = 0;
if (i <= N)
{
while (i <= N)
{ 
    if (i % 2 == 0)
        Console.Write (i + " ");
    i = i + 1 ;
}
}
else
{
while (i >= N)
{ 
    if (i % 2 == 0)
        Console.Write (i + " ");
    i = i - 1 ;
}
}