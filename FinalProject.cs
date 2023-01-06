// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void RecNumbers(int numb)
{
    if(numb == 1) Console.Write($"{numb}");
    else Console.Write($"{numb}, ");
    
    if (numb != 1) RecNumbers(numb - 1);
}

int AskNumber(string numbName)
{
    Console.WriteLine($"Введите число {numbName}: ");
    int n = int.Parse(Console.ReadLine());

    return n;
}

//RecNumbers(AskNumber("N"));

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int RecSum(int m, int n)
{
    int sum = 0;

    if (m == n) return m;
    else return m + RecSum(m + 1, n);
}

void ShowSum(int s)
{
    Console.WriteLine($"{s}");
}

//ShowSum(RecSum(AskNumber("M"), AskNumber("N")));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akerman(int m, int n)
{
    if (m == 0) return n + 1;
    else
    {
        if((m != 0) && (n == 0)) return Akerman(m - 1, 1);
        else return Akerman(m - 1, Akerman(m, n - 1));
    }
}

ShowSum(Akerman(AskNumber("M"), AskNumber("N")));