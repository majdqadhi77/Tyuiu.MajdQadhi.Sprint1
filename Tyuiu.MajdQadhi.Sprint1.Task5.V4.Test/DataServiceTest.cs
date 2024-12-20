using Tyuiu.MajdQadhi.Sprint1.Task5.V4.Lib;

namespace Tyuiu.MajdQadhi.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpress()
        {
            int x = 130985;
            DataService ds = new DataService();
            double res = ds.Calculate(x);

            int result = Convert.ToInt32(res);

            int wait = 9;
            Assert.AreEqual(wait, result);
        }
    }
}