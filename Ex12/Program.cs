//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является 
//ли этот день выходным.

Console.Clear();
int varA;
while (true)
{
    Console.Write("Введите цифру: ");
    if (int.TryParse(Console.ReadLine(), out varA))
        break;
    Console.WriteLine("Ошибка ввода!");
}

if (varA == 6 || varA == 7)
{
    Console.WriteLine("Это выходной день");
}
else if (varA < 1 || varA > 7)
{
    Console.WriteLine("Такого дня недели нет");
}
else
{
    Console.WriteLine("Это не выходной день");
}