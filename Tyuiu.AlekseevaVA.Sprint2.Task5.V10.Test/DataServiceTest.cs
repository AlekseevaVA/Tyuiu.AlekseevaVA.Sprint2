using Tyuiu.AlekseevaVA.Sprint2.Task5.V10.Lib;

namespace Tyuiu.AlekseevaVA.Sprint2.Task5.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            string res = ds.FindDateOfPreviousDay(2025, 10, 1);
            Assert.AreEqual("30.09.2025", res);
        }

    }
}
    

