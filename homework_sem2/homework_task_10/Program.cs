﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначное число число: ");
int number = Convert.ToInt32(Console.ReadLine());

int num1 = (number % 100)*10 / 100;

Console.Write($"Вторая цифра числа: {num1}");