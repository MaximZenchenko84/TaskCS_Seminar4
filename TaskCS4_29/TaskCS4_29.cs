// Урок 4. Задача 29. Напишите программу,
// которая задает массив из 8 элементов и выводит их на экран

using System;

namespace TaskCS4_29
{
    class TaskCS4_29
    {
        static void Main(string[] args)
        {
            int[] array = new int[8]; // объявление массива из 8 элементов
            Random rnd = new Random();
            Console.WriteLine("Введите 8 элементов массива через Enter ");
            for(int i=0; i<array.Length; i++) 
            {
                Console.Write("Введите "); Console.Write(i); Console.Write("-й элемент массива ");
                array[i] = int.Parse(Console.ReadLine());
                //array[i] = rnd.Next();
            }
            Console.Write("Введенные 8 элементов массива: [");
            for (int i = 0; i < array.Length-1; i++)
            {
                Console.Write(array[i]); Console.Write(", ");
            }
            Console.Write(array[array.Length - 1]); Console.WriteLine("]");
        }
    }
}
