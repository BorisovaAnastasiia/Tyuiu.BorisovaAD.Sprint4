using Tyuiu.BorisovaAD.Sprint4.Task4.V19.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: Борисова А. Д. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы c массивами. Класс Array.                   *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #19                                                             *");
        Console.WriteLine("* Выполнил: Борисова Александра Дмитриевна | ИБКСб-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, " +
            "заполненный статическими значениями в диапазоне от 1 до 7. " +
            "Найдите сумму нечетных элементов массива.");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");

        // Статический массив данных из условия
        int[,] matrix = {
            {6, 7, 3, 5, 1},
            {6, 5, 2, 2, 7},
            {2, 6, 4, 6, 6},
            {7, 5, 5, 2, 6},
            {3, 1, 5, 7, 7}
        };

        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        Console.WriteLine("Массив 5x5:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{matrix[i, j]} \t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int sumOddElements = ds.Calculate(matrix);
        Console.WriteLine($"Сумма нечетных элементов массива: {sumOddElements}");

        Console.ReadKey();
    }
}