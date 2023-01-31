using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // Задача 1. Задайте значение N. Напишите программу, которая выведет все 
            // натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

            int N = Quantity.EnterNumber("Введите число: ");
            Quantity.PrintNumber(N);
            Console.WriteLine("\n");

            // Задача 2. Задайте значения M и N. Напишите программу, 
            // которая найдёт сумму натуральных элементов в промежутке от M до N.

            int M = Quantity.EnterNumber("Введите начало промежутка для вычисления суммы: ");
            int N1 = Quantity.EnterNumber("Введите конец промежутка для вычисления суммы: ");
            
            int sum = 0;

            for (int i = M; i <= N1; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Сумма элементов в промежутке от {M} до {N1} = {sum}\n");

            // Задача 3. Напишите программу вычисления функции Аккермана 
            // с помощью рекурсии. Даны два неотрицательных числа m и n.

            int m = Quantity.EnterNumber("Введите первое (неотрицательное) число: ");
            int n = Quantity.EnterNumber("Введите второе (неотрицательное) число: ");

            Console.WriteLine(Quantity.AkkermanFunction(m, n));
        }
    }
}