using System;

namespace PropertiesAndMethods
{
    public class CollectionOfIntegers
    {
        private readonly int[] _numbers;

        public CollectionOfIntegers(int[] numbers)
        {
            _numbers = numbers ?? new int[0];
        }

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < _numbers.Length)
                {
                    // I am inside the array
                    return _numbers[index];
                }

                throw new IndexOutOfRangeException($"Index {index} was outside the bounds of the array (0, {_numbers.Length - 1})");
            }
            set 
            {
                if (index >= 0 && index < _numbers.Length)
                {
                    // I am inside the array
                    _numbers[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException($"Index {index} was outside the bounds of the array (0, {_numbers.Length - 1})");
                }
            }
        }

        public int Max()
        {
            if (_numbers.Length == 0)
            {
                return int.MaxValue;
            }

            int max = _numbers[0];

            for (int i = 0; i < _numbers.Length; i++)
            {
                if (max < _numbers[i])
                {
                    max = _numbers[i];
                }
            }

            return max;
        }
    }
}
