﻿/* Напишите программу, которая на вход принимает два числа 
и проверяет, является ли первое число квадратом второго.
Например:
a=25, b=5 -> да
a=2, b=10 -> нет
a=9, b=-3 -> да
a=-3, b=9 -> нет
*/

Console.Clear();

Console.Write("Введите первое число: ");
string userInput1 = Console.ReadLine() ?? "";
int a = int.Parse(userInput1);

Console.Write("Введите второе число: ");
string userInput2 = Console.ReadLine() ?? "";
int b = int.Parse(userInput2);

/*int a = userNumber1;
int b = userNumber2;
*/

if (a == b * b)
{
    Console.WriteLine($"a={a}, b={b} -> Да");
}

else
{
    Console.WriteLine($"a={a}, b={b} -> Нет");
}




