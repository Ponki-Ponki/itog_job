string[] arr1 = { "hello", "2", "world", "expention", "10", "4930", "-23", "ae" };
string[] arr2 = { "Russian", "Denmark", "Kazan" };
string[] arr3 = { "1231", "435234", "-5", "computer science" };
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

// Выход массива в консоль
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

string[] newArray1 = SortArrayText(arr1);
string[] result1 = EditingArray(newArray1);
System.Console.WriteLine("Создание нового массива где значения не более 3х символов:");
PrintArray(arr1);
System.Console.Write(" -> ");
PrintArray(result1);
System.Console.WriteLine();

string[] newArray2 = SortArrayText(arr2);
string[] result2 = EditingArray(newArray2);
System.Console.WriteLine("Создание нового массива где значения не более 3х символов:");
PrintArray(arr2);
System.Console.Write(" -> ");
PrintArray(result2);
System.Console.WriteLine();

string[] newArray3 = SortArrayText(arr3);
string[] result3 = EditingArray(newArray3);
System.Console.WriteLine("Создание нового массива где значения не более 3х символов:");
PrintArray(arr3);
System.Console.Write(" -> ");
PrintArray(result3);