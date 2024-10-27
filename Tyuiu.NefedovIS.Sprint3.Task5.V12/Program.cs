using Tyuiu.NefedovIS.Sprint3.Task5.V12.Lib;

namespace Tyuiu.NefedovIS.Sprint3.Task5.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 5;
            int start1 = 1;
            int end1 = 3;
            int start2 = 1;
            int end2 = 10;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(x);
            Console.WriteLine(start1);
            Console.WriteLine(end1);
            Console.WriteLine(start2);
            Console.WriteLine(end2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetSumSumSeries(x, start1, start2, end1, end2));
            Console.ReadKey();
        }
    }
}
