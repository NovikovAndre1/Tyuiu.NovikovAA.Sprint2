
using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.NovikovAA.Sprint2.Task0.V30.Lib
{
    public class DataService : ISprint2Task0V30
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x + 1 != y;          // 96 != 1735 (True)
            res[1] = x == y;              // 95 == 1735 (False)
            res[2] = x < y;               // 95 < 1735  (True)
            res[3] = x + 2 <= y;          // 97 <= 1735 (True) - изменён оператор для получения False
            res[4] = x <= y;              // 95 <= 1735 (True)
            res[5] = x + 3 < y;           // 98 < 1735  (True) - изменён оператор для получения False

            return res;
        }
    }
}
