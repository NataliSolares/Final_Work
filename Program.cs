string[] array = new string[] { "3", "---", "string", "write", "//", "123" };
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
Console.Write("result: ");
for (int i = 0; i < array.Length; i++)
{
    string array2 = array[i];
    if (array2.Length <= 3)
    {
        Console.Write($"{array[i]} ");
    }
}

