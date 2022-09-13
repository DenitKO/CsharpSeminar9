// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// Функция Аккермана

// m = 3, n = 2 -> A(m,n) = 29

long AckermanFunction(long number, long argument)
{
    if (number == 0)
        return argument + 1;

    if (number > 0 && argument == 0)
    {
        return AckermanFunction(number - 1, 1);
    }
    else
    {
        return AckermanFunction(number - 1, AckermanFunction(number, argument - 1));
    }
}
long end = AckermanFunction(3, 2);
Console.WriteLine(end);
