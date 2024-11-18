
using System.ComponentModel.Design;
using Tyuiu.NovikovAA.Sprint2.Task6.V14.Lib;


namespace Tyuiu.NovikovAA.Sprint2.Task6.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("********************************************************************");
            Console.WriteLine("Исходные данные");
            Console.WriteLine("********************************************************************");


            Console.WriteLine("Введите число k (1 <= k <= 365):");
            int k;
            if (!int.TryParse(Console.ReadLine(), out k) || k < 1 || k > 365)
            {
                Console.WriteLine("Некорректный ввод k!");
                return;
            }

            Console.WriteLine("Введите день недели для 1 января (1-понедельник, 7-воскресенье):");
            int d;
            if (!int.TryParse(Console.ReadLine(), out d) || d < 1 || d > 7)
            {
                Console.WriteLine("Некорректный ввод d!");
                return;
            }

            int dayIndex = (d + k - 1) % 7;
            string dayName = dayIndex switch
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

            Console.WriteLine($"День недели для {k}-го дня года: {dayName}");



            Console.WriteLine("********************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ");
            Console.WriteLine("********************************************************************");

            Console.WriteLine(dayName);

            Console.WriteLine();
        }
    }
}
