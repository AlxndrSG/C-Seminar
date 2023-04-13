/* Напишите программу, которая принимает на вход 
трехзначное число и на выходе показывает последнюю цифру.
Например:
456 -> 6
782 -> 2
918 -> 8
*/

Console.Clear();

Console.Write("Введите трехзначное число: ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);

int a3 = userNumber % 10;

Console.WriteLine($"{userNumber} -> {a3}");




