using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NefedovIS.Sprint3.Task3.V8.Lib
{
    public class DataService: ISprint3Task3V8
    {
        public int ConvertStringToInt(string value) //
        {
            string str = "";
            foreach (char c in value)
            {
                if (Char.IsDigit(c))
                {
                    str += c;
                }
            }
            return Convert.ToInt32(str);
        }
    }
}
