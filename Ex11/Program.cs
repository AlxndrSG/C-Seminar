//Напишите программу, которая выводит третью 
//цифру заданного числа или сообщает, 
//что третьей цифры нет.

Console.Clear();
int varA;
while (true)
{
    Console.Write("Введите число: ");
    if (int.TryParse(Console.ReadLine(), out varA))
        break;
    Console.WriteLine("Ошибка ввода!");
}

if (varA >= 100)
{
    while (varA > 999)
    {
        varA = varA / 10;
    }
    int result = varA % 10;
    Console.WriteLine($"Третья цифра -> {result}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
