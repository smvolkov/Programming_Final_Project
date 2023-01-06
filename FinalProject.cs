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

int AskNumber()
{
    Console.WriteLine("Введите число N: ");
    int n = int.Parse(Console.ReadLine());

    return n;
}

RecNumbers(AskNumber());