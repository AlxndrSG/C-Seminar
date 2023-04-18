Console.Clear();
int varA;
while (true)
{
    Console.Write("Введите А: ");
    if (int.TryParse(Console.ReadLine(), out varA))
        break;
    Console.WriteLine("Ошибка ввода!");
}
Console.WriteLine($"A={varA}");
