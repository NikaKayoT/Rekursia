//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
int n = Convert.ToInt32(Console.ReadLine());
int ShowNumbers(int n)
{
    if (n == 1)
    {
        Console.Write(n);
        n = 0;
    }
    if (n > 1)
    {
        Console.Write($"{n},");
        n--;
        ShowNumbers(n);
    }
    return n;
}
ShowNumbers(n);



//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15-> 120
//M = 4; N = 8. -> 30
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = m; i <= n; i++)
{
    sum += i;
}
Console.WriteLine(sum);
Console.ReadLine();



//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3->A(m, n) = 9
//m = 3, n = 2->A(m, n) = 29
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
static int Akkermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Akkermann(m - 1, 1);
    }
    else
    {
        return Akkermann(m - 1, Akkermann(m, n - 1));
    }
}
Console.Write(Akkermann(m, n));
