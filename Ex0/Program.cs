/* Напишите программу, которая на вход принимает число 
и выдает его квадрат (число умноженное на само себя)
Например:
4 ->16
-3 ->9
-7 ->49 
*/

Console.Clear();

Console.Write("Введите число: ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);

int result = userNumber * userNumber;

Console.WriteLine($"{userNumber} -> { result}");
