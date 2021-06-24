using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndMethods
{
    public static class MathUtils
    {
        public static string Sum(string label, params int[] elements)
        {
            if ((elements is null) || (elements.Length == 0))
            {
                return $"{label}: 0";
            }

            int sum = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                sum += elements[i];
            }

            return $"{label}: {sum}";
        }
    }
}
