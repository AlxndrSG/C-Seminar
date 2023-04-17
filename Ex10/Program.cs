// Напишите программу, кторая принимает на вход
// трехзначное число и на выходе показыват вторую
// цифру этого числа.
// Например:
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
int varA;
while (true)
{
    Console.Write("Введите трехзначное число: ");
    if (int.TryParse(Console.ReadLine(), out varA))
    break;
    Console.WriteLine("Ошибка ввода!");
}
if (varA >= 100 && varA < 1000)
{
    int result = (varA % 100 - varA % 10) / 10;
    Console.WriteLine($"{varA}-> {result}");
}
else
    {
        Console.WriteLine("Это не трехзначное число");
    }
