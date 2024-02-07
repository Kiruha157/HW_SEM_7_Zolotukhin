// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int[] array = {1, 2, 3, 4, 5};
int lengthArr = array.Length - 1;

void ShowArrReverse(int[] arr, int len)
{
    int i = len;
    if(len == 0)
    {
        Console.Write(arr[i]);
        return;
    }
    Console.Write(arr[i] + " ");
    ShowArrReverse(arr, i - 1);
}

Console.WriteLine($"Вывод элементов массива [{string.Join(" ", array)}]: ");

ShowArrReverse(array, lengthArr);

Console.WriteLine();