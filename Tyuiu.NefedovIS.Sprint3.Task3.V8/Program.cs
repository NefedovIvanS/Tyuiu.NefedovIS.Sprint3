using Tyuiu.NefedovIS.Sprint3.Task3.V8.Lib;

namespace Tyuiu.NefedovIS.Sprint3.Task3.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string value = "vc,x12fc fc!e";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.ConvertStringToInt(value));
            Console.ReadKey();
        }
    }
}
