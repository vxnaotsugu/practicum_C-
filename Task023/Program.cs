﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N");
Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
int a = 1;
int b = 0;
while (a <= n) 
{
    b = a*a*a;
    Console.Write($"{b}, ");
    a += 1;
}