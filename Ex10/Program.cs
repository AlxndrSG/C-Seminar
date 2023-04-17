// Напишите программу, кторая принимает на вход
// трехзначное число и на выходе показыват вторую
// цифру этого числа.
// Например:
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
int intA;
while (true)
{
    Console.Write("Введите трехзначное число: ");
    if (int.TryParse(Console.ReadLine(), out intA));
        break;
    Console.WriteLine("Ошибка ввода!");
}
if (intA >= 100 && intA < 1000)
{
    int result = (intA % 100 - intA % 10) / 10;
    Console.WriteLine($"{intA}-> {result}");
}
else
    {
        Console.WriteLine("Это не трехзначное число");
    }