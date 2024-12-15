using Tyuiu.MajdQadhi.Sprint1.Task2.V18.Lib;
namespace Tyuiu.MajdQadhi.Sprint1.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int t = 0;
            var res = ds.ConvertKelvinToCelsius(t);
            Assert.AreEqual(-273, res);
        }
    }
}