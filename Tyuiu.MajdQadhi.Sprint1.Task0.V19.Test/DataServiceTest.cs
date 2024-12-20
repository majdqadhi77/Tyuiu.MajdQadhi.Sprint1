using Tyuiu.MajdQadhi.Sprint1.Task0.V19.Lib;

namespace Tyuiu.MajdQadhi.Sprint1.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTEst
    {
        [TestMethod]
        public void VoidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);
        }
    }
}