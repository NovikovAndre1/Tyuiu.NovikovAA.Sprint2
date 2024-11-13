using Tyuiu.NovikovAA.Sprint2.Task2.V27.Lib;


namespace Tyuiu.NovikovAA.Sprint2.Task2.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************************************************************");
            Console.WriteLine("Исходные данные");
            Console.WriteLine("********************************************************************");

            Console.WriteLine("Введите значение х:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение y:");
            int y = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);


            Console.WriteLine("********************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ");
            Console.WriteLine("********************************************************************");

            if (res)
            {
                Console.WriteLine("Точка находится в закрашенной области");
            }
            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области");
            }

            Console.ReadKey();
        }
    }
}
