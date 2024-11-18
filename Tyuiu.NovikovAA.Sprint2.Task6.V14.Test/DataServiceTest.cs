
using Tyuiu.NovikovAA.Sprint2.Task6.V14.Lib;


namespace Tyuiu.NovikovAA.Sprint2.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual("�����������", ds.FindDayName(1, 1));
            Assert.AreEqual("�������", ds.FindDayName(2, 2));
            Assert.AreEqual("�����", ds.FindDayName(3, 3));
            Assert.AreEqual("�������", ds.FindDayName(4, 4));
            Assert.AreEqual("�������", ds.FindDayName(5, 5));
            Assert.AreEqual("�������", ds.FindDayName(6, 6));
            Assert.AreEqual("�����������", ds.FindDayName(7, 7));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(-1, -1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(368, 369);
            });
        }
    }
}