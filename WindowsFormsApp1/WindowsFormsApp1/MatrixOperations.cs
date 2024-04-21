using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class MatrixOperations
    {
        public double[,] data;
        public int RowsNumber
        {
            get
            {
                return data.GetLength(0);
            }
        }
        public int ColumnNumber
        {
            get
            {
                return data.GetLength(1);
            }
        }
        bool indexCorrect(int rowIndex, int columnIndex)
        {
            return (rowIndex >= 0 && rowIndex < data.GetLength(0)) && (columnIndex >= 0 && columnIndex < data.GetLength(0));
        }
        public double this[int rowIndex, int columnIndex]
        {
            get
            {
                if (!indexCorrect(rowIndex, columnIndex))
                    throw new Exception("Error");
                return data[rowIndex, columnIndex];

            }
            set
            {
                if(!indexCorrect(rowIndex, columnIndex))
                    throw new Exception("Error");
                data[rowIndex, columnIndex] = value;
            }
        }
        public MatrixOperations(DataGridView gridView)
        {
            data = fromGrid(gridView);
        }
        double[,] fromGrid(DataGridView grid)
        {
            double[,] matrix = new double[grid.RowCount,grid.ColumnCount];
            for(int i = 0; i < grid.RowCount; i++)
            {
                for(int j = 0; j < grid.ColumnCount; j++)
                {
                    matrix[i,j] = Convert.ToDouble(grid[j,i].Value);
                }
            }
            return matrix;
        }
        public static double getSum(DataGridView grid)
        {
            double sum = 0;
            for(int i = 0;i < grid.RowCount; i++)
            {
                for(int j = 0; j<grid.ColumnCount; j++)
                {
                    sum += Convert.ToDouble(grid[j,i].Value);
                }
            }
            return sum;
        }
        public static double getMax(DataGridView grid)
        {
            double max = 0;
            for (int i = 0; i < grid.RowCount; i++)
            {
                for (int j = 0; j < grid.ColumnCount; j++)
                {
                    max = Convert.ToDouble(grid[j, i].Value);
                }
            }
            return max;
        }
    }
}
