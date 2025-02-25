﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            int maximumColumArray = 10;

            Random random = new Random();

            int[] array = new int[random.Next(0, maximumColumArray)];

            FillArray(array);
            Console.WriteLine("Исходный массив");
            OutArray(array);
            ShuffleArray(array);
            Console.WriteLine("\nПеремешанный массив");
            OutArray(array);
        }

        static void FillArray(int[] array)
        {
            Random random = new Random();

            int maximumNumbers = 10;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, maximumNumbers);
            }
        }

        static void OutArray(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

        }

        static void ShuffleArray(int[] array)
        {
            Random random = new Random();

            for (int i = array.Length - 1; i >= 0; i--)
            {
                int randomItem = random.Next(i);
                int shuffledElement = array[randomItem];
                array[randomItem] = array[i];
                array[i] = shuffledElement;
            }

        }
    }
}
