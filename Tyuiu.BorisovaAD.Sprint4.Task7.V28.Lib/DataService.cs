using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BorisovaAD.Sprint4.Task7.V28.Lib
{
    public class DataService : ISprint4Task7V28
    {
        public int Calculate(int n, int m, string value)
        {
            int rows = n;
            int columns = m;
            int[,] matrix = new int[rows, columns];

            // Преобразуем строку в двумерный массив (матрицу)
            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    // Преобразуем символ в целое число
                    matrix[i, j] = int.Parse(value[index].ToString());
                    index++;
                }
            }

            // Подсчитываем произведение четных чисел
            int productEven = 1; // Начинаем с 1 для произведения
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        productEven *= matrix[i, j];
                    }
                }
            }

            return productEven;
        }
    }
}
