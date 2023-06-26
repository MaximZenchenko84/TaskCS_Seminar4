// Урок 4. Задача 27. Напишите программу,
// которая принимает на вход число и выдает сумму цифр в числе 

using System;

namespace TaskCS4_27
{
    class TaskCS4_27
    {
        // функция нахождения суммы цифр в числе
        static int digit_sum(int input_number)
        {
            int result = 0; // сумма цифр
            int current_number = input_number; // текущее число
            while (current_number > 0)
            {
                result += current_number % 10;
                current_number -= current_number % 10;
                current_number /= 10;
            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите целое положительное число = ");
            int B = int.Parse(Console.ReadLine());
            int summa_cifr;
            summa_cifr = 0;
            if (B < 0)
            {
                Console.WriteLine("Некорректный ввод");
                return;
            }
            summa_cifr = digit_sum(B);
            Console.Write("Сумма цифр введенного числа "); Console.Write(B);
            Console.Write(" равна "); Console.WriteLine(summa_cifr);
        }
    }
}
