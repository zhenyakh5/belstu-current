using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 3, 5, 7, 2, 8, 6 };
        string text = "Hello";
        var result = GetArrayStats(numbers, text);

        Console.WriteLine($"Максимальный элемент: {result.Max}");
        Console.WriteLine($"Минимальный элемент: {result.Min}");
        Console.WriteLine($"Сумма элементов: {result.Sum}");
        Console.WriteLine($"Первая буква строки: {result.FirstLetter}");
    }

    static (int Max, int Min, int Sum, char FirstLetter) GetArrayStats(int[] array, string str)
    {
        int max = array.Max();
        int min = array.Min();
        int sum = array.Sum();
        char firstLetter = str[0];

        return (max, min, sum, firstLetter);
    }

}
