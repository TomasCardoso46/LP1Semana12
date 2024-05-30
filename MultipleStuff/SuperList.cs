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

    }
}
