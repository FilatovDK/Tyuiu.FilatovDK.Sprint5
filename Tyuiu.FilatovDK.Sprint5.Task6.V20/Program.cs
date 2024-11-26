using Tyuiu.FilatovDK.Sprint5.Task6.V20.Lib;
namespace Tyuiu.FilatovDK.Sprint5.Task6.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Спринт #5 | Выполнил: Филатов.Д.К | СМАРТБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Филатов Денис Константинович |  СМАРТБ-24-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V20.txt";





            Console.WriteLine("данные находятся в файле " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);

        }
    }
}