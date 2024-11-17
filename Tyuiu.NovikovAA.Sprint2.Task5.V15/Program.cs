
using Tyuiu.NovikovAA.Sprint2.Task5.V15.Lib;


namespace Tyuiu.NovikovAA.Sprint2.Task5.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("********************************************************************");
            Console.WriteLine("Исходные данные");
            Console.WriteLine("********************************************************************");

            Console.WriteLine("Введите номер дня:");
            int k = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((k <= 1) || (k >= 365)) 
            {
                res = "Введено неверное значение!";
            }
            else 
            {
                res = "Это день: " + ds.FindDayName(k);
            }

            Console.WriteLine("********************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ");
            Console.WriteLine("********************************************************************");

            Console.WriteLine(res);

            Console.WriteLine();
        }
    }
}
