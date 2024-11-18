
using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.NovikovAA.Sprint2.Task6.V14.Lib
{
    public class DataService : ISprint2Task6V14
    {
        public string FindDayName(int k, int d)
        {
            if (k < 1 || k > 365 || d < 1 || d > 7)
            {
                return "Invalid input"; // Обработка некорректного ввода
            }

            int dayIndex = (d + k - 1) % 7;
            return dayIndex switch
            {
                0 => "воскресенье",
                1 => "понедельник",
                2 => "вторник",
                3 => "среда",
                4 => "четверг",
                5 => "пятница",
                6 => "суббота",
                _ => "Неизвестный день" // Обработка неожиданного значения
            };
        }
    }
    
}
