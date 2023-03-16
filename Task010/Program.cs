// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначное число");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 / 1000 > 1)
{
    if (number1 / 10000 > 1)
    {
        
    }
    number1 = number1 % 100;
    number1 = number1 / 10;
    Console.WriteLine(number1);
}
else
{
    Console.WriteLine("Число не трехзначное");
}