using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.FilippovaVD.Sprint1.Task3.V9.Lib
{
    public class DataService : ISprint1Task3V9
    {
        public double ConvertMinutesToHours(int minuta)
        {
            return minuta / 60.0;
        }

        public (int hours, int minutes) GetHoursAndMinutes(int totalMinutes)
        {
            int hours = totalMinutes / 60;
            int minutes = totalMinutes % 60;
            return (hours, minutes);
        }
    }
}
