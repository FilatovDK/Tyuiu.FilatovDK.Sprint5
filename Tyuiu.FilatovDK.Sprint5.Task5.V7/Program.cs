﻿using Tyuiu.FilatovDK.Sprint5.Task5.V7.Lib;
namespace Tyuiu.FilatovDK.Sprint5.Task5.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Филатов Д.К. | СМАРТб-24-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                              *");
            Console.WriteLine("* Задание #5                                                                  *");
            Console.WriteLine("* Вариант #7                                                                  *");
            Console.WriteLine("* Выполнил: Филатов Денис Константинович | СМАРТб-24-1                        *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Найти факториал первого целого числа в файле.                               *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V7.txt";

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);



            Console.ReadKey();
        }
    }
}