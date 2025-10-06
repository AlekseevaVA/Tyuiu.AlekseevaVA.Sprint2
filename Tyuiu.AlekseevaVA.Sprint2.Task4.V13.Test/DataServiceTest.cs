using Tyuiu.AlekseevaVA.Sprint2.Task4.V13.Lib;


namespace Tyuiu.AlekseevaVA.Sprint2.Task4.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double res = ds.Calculate(x, y);
            double wait = 31.5;
            Assert.AreEqual(wait, res);


        }
        
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 16;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 65.938;
            Assert.AreEqual(wait, res);
        }
    }
}
