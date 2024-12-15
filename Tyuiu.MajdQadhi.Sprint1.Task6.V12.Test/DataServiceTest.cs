using Tyuiu.MajdQadhi.Sprint1.Task6.V12.Lib;
namespace Tyuiu.MajdQadhi.Sprint1.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string strtest = "asdaoksojdasoHelloasdgdaha";
            var res = ds.CheckHello(strtest);
            Assert.IsTrue(res);
        }
    }
}
