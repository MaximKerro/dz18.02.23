// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Clear();

Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
if (num < 100 || num >= 1000)
{
    Console.WriteLine("Число не трехзначное");
    return;
}
Console.Write($"{num} -> ");
int secondnum = num / 10 % 10;
Console.WriteLine($"Вторая цифра: {secondnum}");
