Console.Clear();

int num = GetNumberFromUser("Введите число A: ", "Ошибка ввода!");

int comNumbers = GetComNumbers(num);

PrintReport(num, comNumbers);

void PrintReport(int num, int number)
{
    Console.WriteLine($"{num} -> {number}");
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
int GetComNumbers(int number)
{
    int com = 1;
    while (number > 1)
    {
        com *= number;
        number--;
    }
    return com;
}