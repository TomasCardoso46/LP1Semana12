using System;

namespace MultipleStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperList superList = new SuperList { 5.2, 3.1, 8.4, 1.9, 7.3 };
            superList.GetMinMax1(out double min1, out double max1);
            Console.WriteLine($"GetMinMax1 - Min: {min1}, Max: {max1}");
            var minMax2 = superList.GetMinMax2();
            Console.WriteLine($"GetMinMax2 - Min: {minMax2.Min}, Max: {minMax2.Max}");
            var minMax3 = superList.GetMinMax3();
            Console.WriteLine($"GetMinMax3 - Min: {minMax3.Item1}, Max: {minMax3.Item2}");
            var (min4, max4) = superList.GetMinMax4();
            Console.WriteLine($"GetMinMax4 - Min: {min4}, Max: {max4}");
        }
    }
}

