
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

            Console.WriteLine("Введите номер дня");
            int numMouth = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((numMouth < 1) ||  (numMouth > 7)) 
            {
                res = "Введено неверное значение!";
            }
            else 
            {
                res = "Это день: " + ds.FindDayName(numMouth);
            }

            Console.WriteLine("********************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ");
            Console.WriteLine("********************************************************************");

            Console.WriteLine(res);

            Console.WriteLine();
        }
    }
}
