﻿// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

bool Pow(int arg1, int arg2)
{
    if (a * a == b || b * b == a)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool res = Pow(a, b);

if (res == true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
