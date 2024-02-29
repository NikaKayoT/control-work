string userText = Console.ReadLine();
string[] str;
if (userText.Length == 0)
{
    str = new string[] { "Hello", "2", "world", ":-", "cat" };
}
else
{
    char[] delimiterChars = { '"', ',', ' ', '[', ']' };
    str = userText.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
}
string[] KeepNewArray(string[] array)
{
    int sizeNewArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            sizeNewArray++;
        }
    }
    string[] newArray = new string[sizeNewArray];
    int newIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[newIndex] = array[i];
            newIndex++;
        }
    }
    str = newArray;
    return newArray;
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }
    Console.WriteLine();
}
KeepNewArray(str);
PrintArray(str);