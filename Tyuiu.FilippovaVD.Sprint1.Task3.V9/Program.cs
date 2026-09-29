// See https://aka.ms/new-console-template for more information
using Tyuiu.FilippovaVD.Sprint1.Task3.V9.Lib;
namespace Tyuiu.FilippovaVD.Sprint1.Task3.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Филиппова В. Д.| АСОиУб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Филиппова Валерия Денисовна | АСОиУб-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу пересчёта величины временного интервала, заданного   *");
            Console.WriteLine("* в минутах, в величину, выраженную в часах и минутах.                    *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите временной интервал (в минутах)");
            int minutesInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double totalHours = ds.ConvertMinutesToHours(minutesInput);

            int hours = minutesInput / 60;
            int remainingMinutes = minutesInput % 60;

            Console.WriteLine($"{minutesInput} минут - это {hours} ч. {remainingMinutes} мин.");
            
            Console.ReadLine();
        }
    }
}
