﻿using System;
using System.Collections.Generic;

namespace work_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            bool continueCounting = true;

            while (continueCounting)
            {
                Console.WriteLine("Введите число, exit или sum: ");
                string messageUser = Console.ReadLine();

                if (int.TryParse(messageUser, out int number))
                    numbers.Add(number);

                Sum(messageUser, numbers);
                
                if(messageUser == "exit")
                    continueCounting = false;
            }
        }

        static void Sum (string messageUser, List<int> numbers)
        {

            if (messageUser == "sum")
            {
                int sum = 0;

                for (int i = 0; i < numbers.Count; i++)
                    sum += numbers[i];

                Console.WriteLine("Sum = " + sum);
            }
        }
    }
}
