
using Tyuiu.NovikovAA.Sprint2.Task4.V20.Lib;


namespace Tyuiu.NovikovAA.Sprint2.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double res = ds.Calculate(x, y);
            double wait = 32;
            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double res = ds.Calculate(x, y);
            double wait = 32;
            Assert.AreEqual(wait, res);

        }
    }
}