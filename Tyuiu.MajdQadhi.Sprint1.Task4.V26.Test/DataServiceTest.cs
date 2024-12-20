using Tyuiu.MajdQadhi.Sprint1.Task4.V26.Lib;

namespace Tyuiu.MajdQadhi.Sprint1.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpress()
        {
            DataService ds = new DataService();
            double x = 3;
            double wait = 0.04;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);

        }
    }
}