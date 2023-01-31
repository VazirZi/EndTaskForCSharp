public static class Quantity
{
    public static int EnterNumber(string str)       // ввод значений в консоли
    {
        Console.Write(str);
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        return number;
    }
    
    public static void PrintNumber(int N)
    {
        if (N > 0)
        {
            Console.Write($"{N} ");
            PrintNumber(N - 1);
        }
    }

    public static int AkkermanFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return AkkermanFunction(m - 1, 1);
        }
        return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    }
    
}