using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndMethods
{
    public class MatrixHelper
    {
        private readonly int[,] _matrix;

        public MatrixHelper(int[,] matrix)
        {
            _matrix = matrix ?? new int[0, 0];
        }

        public int this[int row, int col]
        {
            get
            {
                if (!IsCoordinateInsideMatrix(row, col))
                {
                    throw new IndexOutOfRangeException();
                }

                return _matrix[row, col];
            }
            set
            {
                if (!IsCoordinateInsideMatrix(row, col))
                {
                    throw new IndexOutOfRangeException();
                }

                _matrix[row, col] = value;
            }
        }

        public void PrintMainDiagonal()
        {
            int rowsCount = _matrix.GetLength(0);
            int colsCount = _matrix.GetLength(1);

            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < Math.Min(rowsCount, colsCount); i++)
            {
                Console.Write($"{_matrix[i, i]}, ");
            }

            Console.WriteLine();
        }

        private bool IsCoordinateInsideMatrix(int row, int col)
        {
            return row >= 0 &&
                   row < _matrix.GetLength(0) &&
                   col >= 0 &&
                   col < _matrix.GetLength(1);
        }
    }
}
