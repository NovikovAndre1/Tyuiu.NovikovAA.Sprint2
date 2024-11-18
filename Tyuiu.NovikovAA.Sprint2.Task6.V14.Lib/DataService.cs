
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
                0 => "Воскресенье",
                1 => "Понедельник",
                2 => "Вторник",
                3 => "Среда",
                4 => "Четверг",
                5 => "Пятница",
                6 => "Суббота",
                _ => "Неизвестный день" // Обработка неожиданного значения
            };
        }
    }
    
}
