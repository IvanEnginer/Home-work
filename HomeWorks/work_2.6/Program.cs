﻿using System;

namespace work_2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //При помощи всего, что вы изучили, создать приложение, которое может обрабатывать команды.
            //Т.е.вы создаете меню, ожидаете ввода нужной команды, после чего выполняете действие, которое присвоено этой команде.
            //Примеры команд(требуется 4 - 6 команд, придумать самим):
            //SetName – установить имя;

            //ChangeConsoleColor - изменить цвет консоли;

            //SetPassword – установить пароль;

            //WriteName – вывести имя(после ввода пароля);

            //Esc – выход из программы.

            //Программа не должна завершаться после ввода, 
            //пользователь сам должен выйти из программы при помощи команды. 

            // Программа для создания вашего отряда
            // укажите название команды
            // укажите чило игроков в команде
            // укажите цвет вашей команды 
            // введите секретное слово для опозноования
            // завершить формирование команды  

            string setTeamName = "Нет иформации";
            string changeFlagCollar = "Нет иформации";
            string setSicretSign = "Нет иформации";
            int choisCommand, setGamers = 0;
            bool whileSetGetTeamData = true;


            //Console.WriteLine("Программа для создания вашего отряда.\n\n" +
            //    "Для ввода названия команды введите 1, после введите название.\n" +
            //    "Для ввода числа игроков введите 2.\n" +
            //    "Для выбора цвета флага команды 3, после введите один из цветов крансный, блый, голубой.\n" + 
            //    "Для ввода секретного слова введите 4.\n" +
            //    "Для вывода иформации о команде введите 5.\n" +
            //    "Для завешения программы введите 6.");
            while(whileSetGetTeamData)
            {
                Console.WriteLine("Программа для создания вашего отряда.\n\n" +
                    "Для ввода названия команды введите 1.\n" +
                    "Для ввода числа игроков введите 2.\n" +
                    "Для выбора цвета флага команды 3.\n" +
                    "Для ввода секретного слова введите 4.\n" +
                    "Для вывода иформации о команде введите 5.\n" +
                    "Для завешения программы введите 6.");
                choisCommand = Convert.ToInt32(Console.ReadLine());
                switch(choisCommand)
                {
                    case 1:
                        Console.Write("Введите название команды : ");
                        setTeamName = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("ВВедите введите количество игроков : ");
                        setGamers = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.Write("Выберете один из цветов зеленый или черный : ");
                        changeFlagCollar = Console.ReadLine();
                        if (changeFlagCollar == "зеленый") Console.BackgroundColor = ConsoleColor.Green;
                            break;
                    case 4:
                        Console.Write("ВВедите введите введите секретное слово : ");
                        setSicretSign = Console.ReadLine();
                        break;
                    case 5:
                        Console.Write("Введите секретное слово что бы просмотреть информацию о команде : ");
                        if (Console.ReadLine() == setSicretSign)
                        {
                            Console.WriteLine($"Ваша команда называеться  : {setTeamName}\n" +
                                $"Колличество игроков : {setGamers}\n" +
                                $"Цвет флага : {changeFlagCollar}\n" +
                                $"Секретное слово : {setSicretSign}");
                        }
                            else
                            {
                            Console.WriteLine("Вы ввели неправильное секретное слово");
                            }                                              
                        break;
                    case 6:
                        whileSetGetTeamData = false;
                        break;
                }
            }
        }
    }
}
