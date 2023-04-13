/* Напишите программу, которая будет выдавать 
название дня недели по заданному номеру.
Например:
3 -> Среда
5 -> Пятница
*/

Console.Clear();

Console.Write("Введите номер дня недели: ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);

if (userNumber == 1)
{
    Console.WriteLine($"{userNumber} -> Понедельник");
}
else if (userNumber == 2)
{
    Console.WriteLine($"{userNumber} -> Вторник");
}
else if (userNumber == 3)
{
    Console.WriteLine($"{userNumber} -> Среда");
}
else if (userNumber == 4)
{
    Console.WriteLine($"{userNumber} -> Четверг");
}
else if (userNumber == 5)
{
    Console.WriteLine($"{userNumber} -> Пятница");
}
else if (userNumber == 6)
{
    Console.WriteLine($"{userNumber} -> Суббота");
}
else if (userNumber == 7)
{
    Console.WriteLine($"{userNumber} -> Воскресенье");
}
else
{
    Console.WriteLine($"Такого дня недели не существует");
}