// See https://aka.ms/new-console-template for more information
using Tyuiu.FilippovaVD.Sprint1.Task6.V14.Lib;
namespace Tyuiu.FilippovaVD.Sprint1.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Филиппова В. Д.| АСОиУб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Филиппова Валерия Денисовна | АСОиУб-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Пользователь вводит текст. Проверить, что строка составлена только из   *");
            Console.WriteLine("* строчных русских букв.                                                  *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите текст: ");
            string inputText = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool isOnlyLowerRus = ds.CheckLowerCaseRusLetters(inputText);

            if (isOnlyLowerRus)
            {
                Console.WriteLine("Строка состоит только из строчных русских букв.");
            }
            else
            {
                Console.WriteLine("Строка НЕ состоит только из строчных русских букв (есть другие символы).");
            }

            Console.ReadLine();
        }
    }
}


