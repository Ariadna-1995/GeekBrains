//Задача 2: Напишите программу, которая на вход принимает 2 числа и выдает,
// какое число большее, а какое меньшее. 
Console.Write("Введите 1-е число ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-е число ");
int num2 = int.Parse(Console.ReadLine()!);
if (num1 > num2)
{
    Console.Write($"{num1} - максимальное число");
}
else (num2 > num1)
{
    Console.Write($"{num2} - максимальное число");
}