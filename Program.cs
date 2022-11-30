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

int CountReturnNull(string[] array)
{
    int count =0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] != null) count++;
    }
    return count;
}

string[] EditingArray(string[] arrayResult)
{
    int count = CountReturn(arrayResult);
    string[] arrNewResult = new string[count];
    int l = 0;
    for (int i = 0; i < arrayResult.Length; i++)
    {
        if (arrayResult[i] != null)
        {
            arrNewResult[l++] = arrayResult[i];
        }
    }
    return arrNewResult;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}

string[] newArray = SortArrayText(arr);
string[] result = EditingArray(newArray);
PrintArray(result);