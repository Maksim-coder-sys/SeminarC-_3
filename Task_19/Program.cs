﻿//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да
Console.WriteLine("Введите пятизначное число");
string? str = Console.ReadLine();
if (str.Length == 5)
    {
        if(str[0] == str[4] & str[1] == str[3])
            {
                Console.WriteLine("Это полиндром");
            }
        else
            {
                Console.WriteLine("Это не полиндром");  
            }

    }
else
    {
        Console.WriteLine("Число не пятизначное");
    }