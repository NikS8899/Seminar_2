﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{int secondDigit = number / 10 % 10;
Console.WriteLine("Вторая цифра числа: " + secondDigit);}

else {System.Console.WriteLine("Число не трехзначное!");}
