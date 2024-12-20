using Tyuiu.MajdQadhi.Sprint1.Task3.V12.Lib; 

namespace Tyuiu.MajdQadhi.Sprint1.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.75;
            double y = 0.5;
            int wait = 7;
            var res = ds.PurchaseAmount(x, y, wait);
            Assert.AreEqual(22.75, res);
        }
    }
}