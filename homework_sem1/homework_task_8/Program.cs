﻿// Задача 8: Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
while(count < number)
{
    count++;
    int even_count = count % 2;
    if(even_count == 0)
    {
        Console.WriteLine(count);
    }
}