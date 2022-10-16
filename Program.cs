//Задача 2: Напишите программу, которая на вход принимает 2 числа и выдает,
// какое число большее, а какое меньшее. 
Console.Write("Введите 1-е число ");
int a = int.Parse(Console.ReadLine ()!);
Console.Write("Введите 2-е число ");
int b = int.Parse(Console.ReadLine ()!);
if (a>b)
{
    Console.Write($"{int a} - максимальное число");
}
else (b>a)
{
    Console.Write($"{int b} - максимальное число");
}