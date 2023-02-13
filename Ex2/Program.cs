//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write("Введите первое число: ");
int n1 = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = Convert.ToInt16(Console.ReadLine());
if(n1 > n2)
{
    Console.WriteLine("max = " + n1);
    Console.WriteLine("min = " + n2);
}
else 
{
    Console.WriteLine("max = " + n2);
    Console.WriteLine("min = " + n1);
}
