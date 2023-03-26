string[] t1 = new string[7] { "begin", "0", "text", "-$%", "%$#@*", "Home", "end" };
string[] t2 = new string[t1.Length];
void SearchThreeCharacters(string[] t1, string[] t2)
{
    int count = 0;
    for (int i = 0; i < t1.Length; i++)
    {
        if (t1[i].Length <= 3) t2[count] = t1[i]; count++;
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SearchThreeCharacters(t1, t2);
PrintArray(t2);
