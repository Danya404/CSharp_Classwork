﻿/* Написать программу, которая получает от пользователя число
 и выводит его квадрат */
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Квадрат числа {number} равен {square}");

