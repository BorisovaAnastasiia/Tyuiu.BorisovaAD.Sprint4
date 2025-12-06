using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BorisovaAD.Sprint4.Task5.V30.Lib
{
    public class DataService : ISprint4Task5V30
    {
        public int Calculate(int[,] matrix)
        {
            int sumPositive = 0;
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        sumPositive += matrix[i, j];
                    }
                }
            }
            return sumPositive;
        }
    }
}
