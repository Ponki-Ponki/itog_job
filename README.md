# Итоговая работа

***В данном коде выполнено решение задачи о создании массива, с отсортированным набором строковых перменных на языке c#***
Так как на языке c# нельзя создать массив без размера, то приходится использовать доп. методы.

Тут используется 4 метода: 
* Создание нового массива с отсортированными строковыми значениями
* Пересоздание массива с отсортированными значениями
* Подсчёт не пустых значений в массиве
* Печать массива на экран

1. В первом методе мы проводим отсортировку массива по условию что строковые переменные не более 3х символов
```
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
```

2. Далее происходит пересоздание массива, т.к. при выполнении первого метода мы получаем массив с пустыми значениями.
```
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
```

3. Метод CountReturnNull(arrayResult) предназначен для подсчёта не пустых значений в массиве, и основываясь на этом значении мы можем пересоздать массив во втором методе.


```
int CountReturnNull(string[] array)
{
    int count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] != null) count++;
    }
    return count;
}
```

4. Этот метод стандартный для печати массивов в консоль
```
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
```
---
## Блок схема
Блок схема для данного кода:
---
![Блок-схема](https://github.com/Ponki-Ponki/itog_job/blob/main/diagram.png "Блок-схема решения данной задачи")

