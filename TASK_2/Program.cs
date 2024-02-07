//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int CalcAck (int numM, int numN)
{
    if (numM == 0)
    {
        return numN + 1;
    }
    if (numN == 0)
    {
        return CalcAck (numM - 1, 1);
    }
    int result = CalcAck (numM - 1, CalcAck (numM, numN - 1));
    return result;
}

Console.WriteLine($"Результат вычисления функции Аккермана: {CalcAck(3,10)}");

// Понять бы зачем она нужна на практике...