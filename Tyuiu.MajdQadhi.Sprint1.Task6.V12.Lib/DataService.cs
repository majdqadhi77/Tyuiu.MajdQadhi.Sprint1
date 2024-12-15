using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MajdQadhi.Sprint1.Task6.V12.Lib
{
    public class DataService : ISprint1Task6V12
    {
        public bool CheckHello(string value)
        {
            return value.Contains("Hello");
        }
    }
}
