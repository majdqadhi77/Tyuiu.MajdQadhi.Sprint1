using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MajdQadhi.Sprint1.Task4.V26.Lib
{
    public class DataService : ISprint1Task4V26
    {
        public double Calculate(double x, double y)
        {
            var res = Math.Round(Math.Log(x * y) / (x - (Math.Sqrt(1 + Math.Pow(y, 2)))), 3);
            return res;
        }
    }
}
