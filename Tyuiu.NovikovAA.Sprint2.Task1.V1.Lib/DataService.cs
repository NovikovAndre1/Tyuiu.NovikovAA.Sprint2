
using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.NovikovAA.Sprint2.Task1.V1.Lib
{
    public class DataService : ISprint2Task1V1
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (c < d); // True
            res[1] = (a < b) & (c > d); // False
            res[2] = (a + 2 < b) || (c < d); // True
            res[3] = (a > b) && (c + 3 < d); // False 
            res[4] = !(res![1]); // True
            res[5] = (a + 90 > b) ^ (c < d); // False

            //int a = 119; int b = 196; int c = 134; int d = 327;
            
            return res;
        }
    }
}
