void FillArray(string[] array)
{
    Console.WriteLine("Enter the array values: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        string text = Console.ReadLine() ?? "0";
        array[i] = text;
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        Console.Write($"{array[i]} ");
}

Console.WriteLine("Enter the size of the array: ");
int size = int.Parse(Console.ReadLine() ?? "0");
string[] array = new string[size];
string[] copyarray = new string[size];
FillArray(array);
Console.WriteLine("An array is set, with values:");
PrintArray(array);
