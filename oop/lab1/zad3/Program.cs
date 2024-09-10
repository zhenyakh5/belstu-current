using System;

class Program
{
    static void Main()
    {
        // 3a. Создание целого двумерного массива и вывод его на консоль в отформатированном виде
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        Console.WriteLine("Двумерный массив (матрица):");
        for (int i = 0; i < matrix.GetLength(0); i++) // 0 - первое измерение, строки
        {
            for (int j = 0; j < matrix.GetLength(1); j++) // 1 - второе измерение, столбцы
            {
                Console.Write($"{matrix[i, j], 2}"); // выравнивание по правому краю с шириной в 2 символа
            }
            Console.WriteLine();
        }

        // 3b. Создание одномерного массива строк, вывод его содержимого, длины и изменение элемента
        string[] stringArray = { "apple", "banana", "cherry" };
        Console.WriteLine("\nОдномерный массив строк:");
        for (int i = 0; i < stringArray.Length; i++)
        {
            Console.WriteLine($"Элемент {i}: {stringArray[i]}");
        }
        Console.WriteLine("Длина массива: " + stringArray.Length);

        Console.Write("\nВведите индекс элемента для изменения (0, 1, 2): ");
        int index = Convert.ToInt32(Console.ReadLine()); 
        Console.Write("Введите новое значение: ");
        string newValue = Console.ReadLine();
        if (index >= 0 && index < stringArray.Length)
        {
            stringArray[index] = newValue;
            Console.WriteLine($"Элемент {index} изменен на {newValue}");
        }
        else
        {
            Console.WriteLine("Некорректный индекс.");
        }

        Console.WriteLine("\nИзмененный массив строк:");
        for (int i = 0; i < stringArray.Length; i++)
        {
            Console.WriteLine($"Элемент {i}: {stringArray[i]}");
        }

        // 3c. Создание ступенчатого массива вещественных чисел и ввод значений с консоли
        double[][] jaggedArray = new double[3][];
        jaggedArray[0] = new double[2];
        jaggedArray[1] = new double[3];
        jaggedArray[2] = new double[4];

        Console.WriteLine("\nВведите значения для ступенчатого массива:");

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write($"Введите значение для элемента [{i}, {j}]: ");
                jaggedArray[i][j] = Convert.ToDouble(Console.ReadLine());
            }
        }

        Console.WriteLine("\nСтупенчатый массив:");
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j]);
            }
            Console.WriteLine();
        }

        // 3d. Создание неявно типизированных переменных для массива и строки
        var implicitArray = new[] { 1, 2, 3, 4, 5 }; // Неявно типизированный массив
        var implicitString = "This is an implicit string."; // Неявно типизированная строка

        Console.WriteLine("\nНеявно типизированные переменные:");
        Console.WriteLine("Массив: " + string.Join(", ", implicitArray));
        Console.WriteLine("Строка: " + implicitString);
    }
}