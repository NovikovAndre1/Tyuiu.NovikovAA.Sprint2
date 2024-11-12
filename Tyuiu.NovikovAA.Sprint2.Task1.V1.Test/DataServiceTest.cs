
using Tyuiu.NovikovAA.Sprint2.Task1.V1.Lib;


namespace Tyuiu.NovikovAA.Sprint2.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 119;
            int b = 196;
            int c = 134;
            int d = 327;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { true, false, true, false, true, false };

            CollectionAssert.AreEqual(res, wait);
        }
    }
}