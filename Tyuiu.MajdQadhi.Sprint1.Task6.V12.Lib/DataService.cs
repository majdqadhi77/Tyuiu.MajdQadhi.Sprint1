using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MajdQadhi.Sprint1.Task6.V12.Lib
{
    public class DataService : ISprint1Task6V12
    {
        public string MoveLetterToStart(string value)
        {
            string[] words = value.Split(' ');
            string result = "";

            foreach (var word in words)
                result += word.Length > 0 ? word[^1] + word[..^1] + " " : "";

            return result.Trim();
        }
    }
}
