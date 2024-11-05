using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1. Определить, имеются ли в одномерном массиве случайных чисел элементы, значения которых кратны 11. Вывести такие значения.
            //int[] omas = new int[10];
            //Random rnd = new Random();
            //for (int i = 0; i < omas.Length; i++)
            //{ 
            // omas[i] = rnd.Next(1,99);
            // Console.WriteLine($"omas[{i}] = {omas[i]}");
            //}
            //Console.WriteLine("Элементы массива, кратные 11:");
            //foreach (int num in omas) 
            //{
            //    if (num % 11 == 0) 
            //    {
            //        Console.WriteLine(num);
            //    }
            //}

            //Задача 2. Найти сумму и количество положительных элементов в одномерном массиве с явной инициализацией.
            //int[] omas = new int[] { 1, 5, -6, -2, 8, -1, 4, 7 };
            //int count = 0, value = 0;
            //foreach (int num in omas)
            //{
            //    if (num > 0)
            //    {
            //        value += num;
            //        count++;
            //    }
            //}
            //Console.WriteLine("Сумма элементов = " + value);
            //Console.WriteLine("количество положительных элементов = " + count);
            //Array.Clear(omas, 0, 3);

            //for (int i = 0; i < omas.Length; i++)
            //{
            //    Console.Write("{0} ", omas[i]);
            //}
            //Console.WriteLine();

            //Задача 3. Вывести элементы одномерного массива, заполненного с клавиатуры ,в обратном порядке.
            //Console.Write("Введите n = ");
            //int n = int.Parse(Console.ReadLine());
            //int[] omas = new int[n];
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    Console.Write($"omas[{i}] = ");
            //    omas[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = omas.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(omas[i]);
            //}

            //Array.Reverse(omas);
            //foreach (int el in omas)
            //{
            //    Console.WriteLine(el);
            //}

            //Задача 2. Изменить размер одномерного массива.
            //int[] omas = new int[10];
            //Random rnd = new Random();
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    omas[i] = rnd.Next(0,100);
            //    Console.WriteLine($"omas[{i}] = {omas[i]}");
            //}
            //Array.Resize(ref omas, 15);
            //foreach (int el in omas)
            //{
            //    Console.WriteLine(el);
            //}

        }
    }
}
