// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

string Natural(int n)
{
    if(n == 1)
    {
        return "1";
    }

    return (n + " " + Natural(n - 1));
}

Console.WriteLine(Natural(n));

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M: ");
int mSum = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N: ");
int nSum = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Число M равно: {mSum}, число N равно: {nSum}. Сумма натуральных чисел в промежутке от M до N равна: {SumInRange(mSum,nSum)}");

int SumInRange(int m, int n)
{
    int count = 1;
    if(m == n)
    {
        return n;
    }
    return m+SumInRange(m+count,n);
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число M: ");
double mAkk = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N: ");
double nAkk = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Число M равно: {mAkk}, число N равно: {nAkk}. Результат вычисления фунции Аккермана А(m,n) равен: {Akkerman(mAkk,nAkk)}.");

double Akkerman (double m, double n)
{
    if (m==0) 
    {
        return n+1;
    }
    else if (m > 0 && n == 0)
    {
        return Akkerman(m-1,1);
    }
    else
    {
        return Akkerman(m-1,Akkerman(m,n-1));
    }

}