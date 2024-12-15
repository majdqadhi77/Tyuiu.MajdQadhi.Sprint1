using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MajdQadhi.Sprint1.Task3.V12.Lib
{
    public class DataService : ISprint1Task3V12
    {
        public double CylinderVolume(double r, double h)
        {
            return Math.Round(Math.PI * (r * r * h),3);
        }
    }
}
