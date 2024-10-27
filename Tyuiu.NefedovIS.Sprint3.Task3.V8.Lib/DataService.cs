namespace Tyuiu.NefedovIS.Sprint3.Task3.V8.Lib
{
    public class DataService
    {
        public int ConvertStringToInt(string value)
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
