Console.Clear();
int[] randomArray = new int[8];
FillArray(randomArray);
Printarray(randomArray);
static void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(0, 2);
        index++;
    }
}
static void Printarray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write($"{collection[index]} ");
        index++;
    }

}
  


/*
int[] randomArray = new int[8];

for (int i = 0; i < 8; i++)
{
randomArray[i] = new Random().Next(0, 2);
Console.Write(randomArray[i] + " ");
}
*/