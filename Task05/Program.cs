﻿// Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N. 

// Добавим условие: Выводит все числа кратны 2ум
// 4 -> "-4, -2, 0, 2, 4"
// 2 -> " -2, 0, 2"

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


for (int i = -number; i <= number; i++) {

    if (i % 2 == 0) {
        Console.Write($"{i} ");
    }
};