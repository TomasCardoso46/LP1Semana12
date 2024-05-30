using System;
using System.Collections.Generic;

namespace MultipleStuff
{
    // SuperList estende List<double>
    public class SuperList : List<double>
    {
        // Versão 1: Parâmetros out
        public void GetMinMax1(out double min, out double max)
        {
            if (Count == 0)
                throw new InvalidOperationException("The list is empty.");

            min = double.MaxValue;
            max = double.MinValue;

            foreach (var number in this)
            {
                if (number < min)
                    min = number;
                if (number > max)
                    max = number;
            }
        }

        // Versão 2: Classe/struct específica
        public struct MinMax
        {
            public double Min;
            public double Max;
        }

        public MinMax GetMinMax2()
        {
            if (Count == 0)
                throw new InvalidOperationException("The list is empty.");

            MinMax result = new MinMax { Min = double.MaxValue, Max = double.MinValue };

            foreach (var number in this)
            {
                if (number < result.Min)
                    result.Min = number;
                if (number > result.Max)
                    result.Max = number;
            }

            return result;
        }

        // Versão 3: Tuplas de referência
        public Tuple<double, double> GetMinMax3()
        {
            if (Count == 0)
                throw new InvalidOperationException("The list is empty.");

            double min = double.MaxValue;
            double max = double.MinValue;

            foreach (var number in this)
            {
                if (number < min)
                    min = number;
                if (number > max)
                    max = number;
            }

            return Tuple.Create(min, max);
        }

        // Versão 4: Tuplas de valor com nomes definidos
        public (double Min, double Max) GetMinMax4()
        {
            if (Count == 0)
                throw new InvalidOperationException("The list is empty.");

            double min = double.MaxValue;
            double max = double.MinValue;

            foreach (var number in this)
            {
                if (number < min)
                    min = number;
                if (number > max)
                    max = number;
            }

            return (min, max);
        }
    }
}
