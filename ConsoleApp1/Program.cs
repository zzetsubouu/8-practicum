using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //вывести четные двузначные числа в столбик подсчитать их количество,найти сумму и среднее арифметическое
            //int i = 0;
            //int summ = 0;
            //double sredarifm = 0;
            //for (int j=10; j<=99; j++)
            //{
            //    if (j%2==0)
            //    {
            //        Console.WriteLine(j);
            //        i++;
            //        summ += j;
            //    }
            //}
            //sredarifm = summ / i;
            //Console.WriteLine($"количество четных чисел:{i}, их сумма = {summ} и среднее арифметическое = {sredarifm}");



            //вывести в обратном порядке двузначные числа кратные 25

            //for (int j = 99; j >=10; j--)
            //{
            //    if (j % 25 == 0)
            //    {
            //        Console.WriteLine(j);
            //    }
            //}




            //Задача 1. Заполнить одномерный массив из 8 целых чисел с клавиатуры и вывести его на экран.
            //int[] omas = new int[8];
            //Console.WriteLine("заполинте о.м.");
            //for (int i = 0; i < 8; i++)
            //{
            //    Console.Write($"omas[{i}]=");
            //    omas[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("вывод одномерного массива:");
            //foreach (int i in omas)
            //{
            //    Console.WriteLine(i);
            //}

            //Задача 2. Составьте программу ввода (без клавиатуры) и вывода массива: 5, -2, 3, -6, 7, 9, -4, 8, 1, 2, 7, -3.
            //int[] omas = new int[12] { 5, -2, 3, -6, 7, 9, -4, 8, 1, 2, 7, -3 };
            //foreach (var element in omas)
            //{
            //    Console.WriteLine(element);
            //}

            //Задача 3. Массив предназначен для хранения значений ростов двенадцати человек.
            //С помощью датчика случайных чисел заполнить массив целыми значениями, лежащими в диапазоне от 163 до 190 включительно.

            //Random rand = new Random();
            //int[] omas = new int[12];
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    int x = rand.Next(163, 191);
            //    omas[i] = x;
            //}
            //foreach (var element in omas)
            //{
            //    Console.WriteLine(element);
            //}


            //доп.задание: найти среднюю температуру воздуха за октябрь месяц.

            Random rand = new Random();
            double srtemp = 0;
            int sum = 0;
            int[] october = new int[31];
            for (int i = 0; i < october.Length; i++)
            {
                int x = rand.Next(5, 25);
                october[i] = x;
                sum += x;
            }
            srtemp = sum / 31.0;
            int count = 1;
            Console.WriteLine("Температура каждого дня в октябре:");
            foreach (int day in october)
            {
            
                Console.WriteLine($"День {count}: {day}°C");
                count++;
            }
            Console.WriteLine($"Средняя температура за месяц: {srtemp:N1}°C");
            Console.ReadKey();
        }
    }
}
