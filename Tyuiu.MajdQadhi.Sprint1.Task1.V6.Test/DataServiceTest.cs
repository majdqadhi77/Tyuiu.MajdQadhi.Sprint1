using Tyuiu.MajdQadhi.Sprint1.Task1.V6.Lib;
namespace Tyuiu.MajdQadhi.Sprint1.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(3, res);
        }
    }
}