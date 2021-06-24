using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndMethods
{
    public class Iterator
    {
        private readonly int[] _numbers;

        public Iterator(int[] numbers)
        {
            _numbers = numbers ?? new int[0];
        }

        public void Iterate()
        {
            IterateRecursive(0);
        }

        private void IterateRecursive(int index)
        {
            if (index >= 0 && index < _numbers.Length)
            {
                Console.WriteLine($"elem[{index}]={_numbers[index]}");

                IterateRecursive(index + 1);
            }
        }
    }
}
