Console.Clear();

int number = GetUserInput("Введите номер четверти: ");

PrinCoordsByQuarter(number);

static int GetUserInput(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

static void PrinCoordsByQuarter(int number)
{
    if (number == 1)
    {
        Console.WriteLine("X > 0, Y > 0");
    }
    else if (number == 2)
    {
        Console.WriteLine("X < 0, Y > 0");
    }
    else if (number == 3)
    {
        Console.WriteLine("X < 0, Y < 0");
    }
    else if (number == 4)
    {
        Console.WriteLine("X > 0, Y < 0");
    }
    else
    {
        Console.WriteLine("Ошибка ввода данных");
    }
}