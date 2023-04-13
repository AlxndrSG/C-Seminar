/* Напишите программу, которая на вход принимает 
одно число (N), а на выходе показывает все 
целые числа в промежутка от -N до N.
Например:
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> "-2, -1, 0, 1, 2"
*/

Console.Clear();

Console.Write("Введите число: ");
string userInput = Console.ReadLine() ?? "";
int N = int.Parse(userInput);

/*for(int i = -N; i <= N; i++)
{
    Console.Write(i + " ");
}
*/

int index = -N - 1;

while (index < N)
{
    index++;

    Console.Write(index + " ");
}

