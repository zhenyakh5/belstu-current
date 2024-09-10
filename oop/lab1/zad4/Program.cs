using System;

class Program
{
    static void Main()
    {
        // 4a. Создание кортежа из 5 элементов
        var tuple = (42, "Hello", 'A', "World", 1234567890UL);

        // 4b. Вывод кортежа на консоль целиком и выборочно
        Console.WriteLine("Кортеж целиком:");
        Console.WriteLine(tuple);

        Console.WriteLine("\nВыборочные элементы:");
        Console.WriteLine($"1-й элемент: {tuple.Item1}");
        Console.WriteLine($"3-й элемент: {tuple.Item3}");
        Console.WriteLine($"4-й элемент: {tuple.Item4}");

        // 4c. Распаковка кортежа в переменные
        var (intValue, stringValue1, charValue, stringValue2, ulongValue) = tuple;

        Console.WriteLine("\nРазличные способы распаковки кортежа:");
        Console.WriteLine($"intValue: {intValue}, stringValue1: {stringValue1}, charValue: {charValue}, stringValue2: {stringValue2}, ulongValue: {ulongValue}");

        var (intValue2, _, charValue2, _, ulongValue2) = tuple;
        Console.WriteLine($"intValue2: {intValue2}, charValue2: {charValue2}, ulongValue2: {ulongValue2}");

        // 4d. Сравнение двух кортежей
        var tuple1 = (42, "Hello", 'A', "World", 1234567890UL);
        var tuple2 = (42, "Hello", 'A', "World", 1234567890UL);
        var tuple3 = (43, "Hello", 'A', "World", 1234567890UL);

        Console.WriteLine("\nСравнение кортежей:");
        Console.WriteLine($"tuple1 == tuple2: {tuple1 == tuple2}"); // True, так как все элементы совпадают
        Console.WriteLine($"tuple1 == tuple3: {tuple1 == tuple3}"); // False, так как первый элемент отличается
    }
}
