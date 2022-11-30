string[] arr = { "hello", "2", "world", "expention", "10", "4930", "-23", "ae" };


string[] SortArrayText(string[] array)
{
    string[] arrSort = new string[array.Length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrSort[j++] = array[i];
        }
    }
    return arrSort;
}



string[] newArray = SortArrayText(arr);
