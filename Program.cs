string[] array = new string[5] {"Hello", "2", "world", ":-)"};
string[] array1 = new string[array.Length];
void GetArray(string[] array, string[] array2)
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