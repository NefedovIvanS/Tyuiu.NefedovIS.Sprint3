using Tyuiu.NefedovIS.Sprint3.Task2.V30.Lib;

namespace Tyuiu.NefedovIS.Sprint3.Task2.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                DataService ds = new DataService();

                double a;
                int startValue;
                int stopValue;

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
                Console.WriteLine("***************************************************************************");

                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("a = " + a);
                startValue = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("startValue = " + startValue);
                stopValue = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("stopValue = " + stopValue);

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");

                Console.WriteLine(ds.GetMultiplySeries(a, startValue, stopValue));
                Console.ReadKey();
            }
        }
    }
}
