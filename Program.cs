string[] array = new string[4] {"Hello", "2", "world", ":-)"};
string[] array1 = new string[array.Length];
void GetArray(string[] array, string[] array1)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        array1[count] = array[i];
        count++;
        }
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
GetArray(array, array1);
PrintArray(array1);