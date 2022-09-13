// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1 (используйте рекурсию).
// N = 5 -> 5, 4, 3, 2, 1

void FillRecursion(int i)
{
    if (i == 1) 
    {
        Console.Write($"{i} ");
    }
    else 
    {
        Console.Write($"{i} ");
        i--;
        RecursionOfNaturalDigit(i);
    }
}

System.Console.Write("Введине натуральное число : ");
string input = Console.ReadLine();
int n;
bool result = int.TryParse(input, out n);
if (result)
{
    if (n<1)
        Console.WriteLine("Ошибка, число не натуральное");
    else 
        FillRecursion(n);
}
else Console.WriteLine("Что то пошло не так, попробуйте еще раз");