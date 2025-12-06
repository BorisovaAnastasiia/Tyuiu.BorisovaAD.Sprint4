using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BorisovaAD.Sprint4.Task4.V19.Lib
{
    public class DataService : ISprint4Task4V19
    {
        public int Calculate(int[,] matrix)
        {
            int sumOdd = 0;
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            // Перебираем все элементы массива
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    // Проверяем, является ли элемент нечетным (остаток от деления на 2 не равен 0)
                    if (matrix[i, j] % 2 != 0)
                    {
                        sumOdd += matrix[i, j];
                    }
                }
            }
            return sumOdd;
        }
    }
}
