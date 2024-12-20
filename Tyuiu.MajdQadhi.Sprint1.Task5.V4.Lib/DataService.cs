using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MajdQadhi.Sprint1.Task5.V4.Lib
{
    public class DataService : ISprint1Task5V4
    {
        public int Calculate(int k)
        {

            int res = (k / 100) % 10;
            return res;
        }
    }
}
