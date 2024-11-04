﻿
using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.NovikovAA.Sprint2.Task0.V30.Lib
{
    public class DataService : ISprint2Task0V30
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x + 1640 == y;
            res[1] = x + 1 != y;
            res[2] = x + 1 < y;
            res[3] = x + 1 > y;
            res[4] = x + 1 <= y;
            res[5] = x + 1 >= y;

            return res;
        }
    }
}
