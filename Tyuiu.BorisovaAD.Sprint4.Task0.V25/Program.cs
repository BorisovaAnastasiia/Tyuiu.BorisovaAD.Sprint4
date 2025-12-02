using Tyuiu.BorisovaAD.Sprint4.Task0.V25.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: Борисова А.Д. | Смартб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы c массивами                                 *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #25                                                             *");
        Console.WriteLine("* Выполнил: Борисова Анастасия Дмитриевна | Смартб-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный " +
            "статическими значениями в диапазоне от 0 до 9 подсчитать сумму четных элементов массива." +
            "  {1, 4, 2, 6, 4, 8, 6, 7, 8, 4}");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");
        // Используем массив из задания Варианта 25
        int[] array = { 1, 4, 2, 6, 4, 8, 6, 7, 8, 4 };
        Console.WriteLine("Массив:");
        for (int i = 0; i <= array.Length - 1; i++)
        {
            Console.Write(array[i] + " "); 
        }
        Console.WriteLine(); // Переход на новую строку после вывода массива
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        // Вызываем метод для получения суммы четных элементов
        int sum = ds.GetSumEvenArrEl(array);
        Console.WriteLine(sum);
        Console.ReadKey();
    }
}