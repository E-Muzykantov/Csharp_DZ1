//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Clear();
Console.Write("Введите первое число: ");
int n1 = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите третье число: ");
int n3 = Convert.ToInt16(Console.ReadLine());
int max = n1;
if (n2 > max) max = n2;
if (n3 > max) max = n3;
Console.WriteLine("max = " + max);