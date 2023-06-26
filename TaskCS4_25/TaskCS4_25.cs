// Урок 4. Задача 25. 
// Напишите цикл, который принимает на вход два числа (A и B) 
// и  возводит число A в натуральную степень B

using System;

namespace TaskCS4_25
{
    class TaskCS4_25
    {
        // функция возведения в степень
        static double stepen(double A, int B)
        {
            double result = A;

            if (B == 0)
            {
                Console.WriteLine(1); // число в степени 0 равно 1
                return 0;
            }

            for (int i = 2; i <= B; i++) // цикл вохведения в степень
            {
                result *= A;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число A = ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Введите целое положительное число B = ");
            int B = int.Parse(Console.ReadLine());
            double result;
            if (B < 0)
            {
                Console.WriteLine("Некорректный ввод");
                return;
            }
            result = stepen(A, B);
            // вывод
            Console.Write(A); Console.Write(" в степени ");
            Console.Write(B); Console.Write(" равно ");
            Console.WriteLine(result);
            return;
        }
    }
}
