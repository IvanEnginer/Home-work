﻿using System;

namespace Work7
{
    class Program
    {
        static void Main(string[] args)
        {
            //// minutsInQuea = peoplsInQeua /timeScope
            //int peoplsInQeua;
            //int timeScope = 10;
            //int hourInQuea;
            //int minutsInQuea;
            //// int pepolsToUseInHours = 60/timeScope;

            //Console.Write("Количество человек в очереди : ");
            //peoplsInQeua = Convert.ToInt32(Console.ReadLine());

            //hourInQuea = peoplsInQeua / timeScope;

            //minutsInQuea = (peoplsInQeua / timeScope)*10;
            //Console.WriteLine($"Вы должны отстоять в очереди {hourInQuea} часа и {minutsInQuea} минут.");

            int peoplsInQeua;
            int timeScope = 10;
            int hourInQuea;
            int totalMinutsInQuea;
            int minutsInQuea;

            Console.Write("Количество человек в очереди : ");
            peoplsInQeua = Convert.ToInt32(Console.ReadLine());

            totalMinutsInQuea = peoplsInQeua * timeScope;
            hourInQuea = totalMinutsInQuea / 60;
            minutsInQuea = totalMinutsInQuea - (hourInQuea * 60);

            Console.WriteLine($"Вы должны отстоять в очереди {hourInQuea} часа и {minutsInQuea} минут.");
        }
    }
}
