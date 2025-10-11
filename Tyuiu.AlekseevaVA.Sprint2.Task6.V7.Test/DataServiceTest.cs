using Tyuiu.AlekseevaVA.Sprint2.Task6.V7.Lib;

namespace Tyuiu.AlekseevaVA.Sprint2.Task6.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual("январь", ds.FindMonthName(1990, 0));
            Assert.AreEqual("февраль", ds.FindMonthName(1990, 1));
            Assert.AreEqual("март", ds.FindMonthName(1990, 2));
            Assert.AreEqual("апрель", ds.FindMonthName(1990, 3));
            Assert.AreEqual("май", ds.FindMonthName(1990, 4));
            Assert.AreEqual("июнь", ds.FindMonthName(1990, 5));
            Assert.AreEqual("июль", ds.FindMonthName(1990, 6));
            Assert.AreEqual("август", ds.FindMonthName(1990, 7));
            Assert.AreEqual("сентябрь", ds.FindMonthName(1990, 8));
            Assert.AreEqual("октябрь", ds.FindMonthName(1990, 9));
            Assert.AreEqual("ноябрь", ds.FindMonthName(1990, 10));
            Assert.AreEqual("декабрь", ds.FindMonthName(1990, 11));
            Assert.AreEqual("январь", ds.FindMonthName(1990, 12));
            Assert.AreEqual("февраль", ds.FindMonthName(1990, 13));
            Assert.AreEqual("январь", ds.FindMonthName(1990, 24));
        }
    }


    
}
