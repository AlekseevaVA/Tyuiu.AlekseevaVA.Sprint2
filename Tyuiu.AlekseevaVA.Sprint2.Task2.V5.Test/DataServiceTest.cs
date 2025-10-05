using Tyuiu.AlekseevaVA.Sprint2.Task2.V5.Lib;

namespace Tyuiu.AlekseevaVA.Sprint2.Task2.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 4;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);


        }
    }
}
