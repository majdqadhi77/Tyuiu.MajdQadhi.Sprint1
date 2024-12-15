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
            double r = 2;
            double h = 3;
            double wait = 37.699;
            var res = ds.CylinderVolume(r, h);
        }
    }
}