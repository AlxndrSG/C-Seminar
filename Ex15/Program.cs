Console.Clear();

int num = GetNumberFromUser("Введите число A: ", "Ошибка ввода!");
int numDigits = GetNumDigits(num);
Console.WriteLine($"{num} -> {numDigits}");

int GetNumDigits(int number)
{
    int result = 0;
        while(number > 0)
        {
            number/=10;
            result++;
        }

    return result;
}

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

