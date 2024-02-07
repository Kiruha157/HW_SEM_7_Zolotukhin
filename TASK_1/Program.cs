
// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void ShowNumbers (int min, int max)
{
    if (min == max) 
    {
        Console.Write(min);
        return;
    }
    Console.Write(min + " ");
    ShowNumbers (min + 1, max);
}

ShowNumbers(5,10);