﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for (int i=0; i<number; i++)
{
    sum = sum + number%10;
    number /= 10; 
}
Console.WriteLine(sum);
