
using Tyuiu.NovikovAA.Sprint2.Task0.V30.Lib;


namespace Tyuiu.NovikovAA.Sprint2.Task0.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService(); // Не используется в этом коде, можно убрать

            int x = 95;
            int y = 1735;
            bool[] res = new bool[6];

            Console.WriteLine("********************************************************************");
            Console.WriteLine("Исходные данные");
            Console.WriteLine("********************************************************************");

            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);

            Console.WriteLine("********************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ");
            Console.WriteLine("********************************************************************");

            res[0] = x + 1 != y;
            res[1] = x == y;
            res[2] = x < y;
            res[3] = x + 2 <= y;
            res[4] = x <= y;
            res[5] = x + 3 < y;

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}
