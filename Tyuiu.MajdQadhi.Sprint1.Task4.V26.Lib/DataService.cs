using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MajdQadhi.Sprint1.Task4.V26.Lib
{
    public class DataService : ISprint1Task4V26
    {
        public double Calculate(double x)
        {
            var res = 1 / (Math.Pow(x+2,2));
            return res;
        }
    }
}
