using Tyuiu.BorisovaAD.Sprint4.Task7.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        // Обновляем информацию под Вашу задачу и ФИО/группу
        Console.Title = "Спринт #4 | Выполнил: Борисова А. Д. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы c массивами. Класс String. Преобразование.  *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #28                                                             *");
        Console.WriteLine("* Выполнил: Борисова Александра Дмитриевна | ИБКСб-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дана строка из одноразрядных цифр \"623351179845632\". Преобразуйте ее  *");
        Console.WriteLine("* в матрицу 5 на 3 и подсчитайте произведение четных чисел.               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");

        string value = "623351179845632";
        int n = 5;
        int m = 3;

        Console.WriteLine($"Исходная строка: {value}");
        Console.WriteLine($"Размерность матрицы: {n}x{m}");

        // Визуализация матрицы
        Console.WriteLine("Сформированная матрица:");
        int index = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{value[index]} \t");
                index++;
            }
            Console.WriteLine();
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        // Вызываем метод Calculate с правильными аргументами
        int productEvenElements = ds.Calculate(n, m, value);
        Console.WriteLine($"Произведение четных чисел в матрице: {productEvenElements}");

        Console.ReadKey();
    }
}