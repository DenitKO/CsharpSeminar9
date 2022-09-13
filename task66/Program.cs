// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N (используйте рекурсию).

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
System.Console.Write("Введинте натуральное число M = ");
int m = int.Parse(System.Console.ReadLine());
System.Console.Write("Введинте натуральное число N = ");
int n = int.Parse(System.Console.ReadLine());

int temp = m;

void RecursiveSumNatural(int a, int b)
{
    if (a == b)
    {
        if (temp == 0) Console.WriteLine($"нулевой темп, a+b = {a} и {b}");
        else Console.WriteLine($"Cумма натуральных элементов в промежутке от M до N = {temp}");
    }
    else
    {
        // Console.WriteLine($"внутри рекурсии, перед её вызовом temp = {temp}");
        temp = temp + b;
        b--;
        
        RecursiveSumNatural(a, b);
    }
}

if (m >= n)
    System.Console.Write("Введите натуральные числа в порядке возрастания");
else if (m<0&&n<0)
    System.Console.Write("Ошибка, введите натуральные числа в порядке возрастания");
else
    RecursiveSumNatural(m, n);