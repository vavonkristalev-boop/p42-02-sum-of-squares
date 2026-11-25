using System;

class Program
{
    // Верните сумму квадратов 1² + 2² + ... + n²
    static int SumOfSquares(int n)
    {
        // TODO: напишите решение здесь
        return n*(n + 1)*(2*n+1)/6;
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Check(2, 5);
        Check(8, 204);
        Check(1, 1);
        Check(10, 385);
        Check(100, 338350);
    }

    static void Check(int n, int expected)
    {
        int result = SumOfSquares(n);
        string status = result == expected ? "OK" : "ОШИБКА";
        Console.WriteLine($"n = {n}: получено {result}, ожидалось {expected} - {status}");
    }
}
