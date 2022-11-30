string[] arr = { "hello", "2", "world", "expention", "10", "4930", "-23", "ae" };

//Создание нового массива с отобранными значениями по условию
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

//Получаем кол-во не пустых элементов в массиве строк
int CountReturnNull(string[] array)
{
    int count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] != null) count++;
    }
    return count;
}
// Пересоздание массива без пустых значений
string[] EditingArray(string[] arrayResult)
{
    int count = CountReturnNull(arrayResult);
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

// Выод массива в консоль
void PrintArray(string[] arr)
{
    Console.Write("['");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != arr.Length - 1) Console.Write(arr[i] + "', '");
        else Console.Write(arr[i]);
    }
    Console.Write("']");
}

string[] newArray = SortArrayText(arr);
string[] result = EditingArray(newArray);
PrintArray(arr);
System.Console.Write(" -> ");
PrintArray(result);