using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите логическое значение (true/false): ");
        bool isTrue = Convert.ToBoolean(Console.ReadLine());

        Console.Write("Введите целое число типа byte (0-255): ");
        byte byteValue = Convert.ToByte(Console.ReadLine());

        Console.Write("Введите целое число типа sbyte (-128 - 127): ");
        sbyte sbyteValue = Convert.ToSByte(Console.ReadLine());

        Console.Write("Введите символ: ");
        char charValue = Convert.ToChar(Console.ReadLine());

        Console.Write("Введите десятичное число типа decimal: ");
        decimal decimalValue = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Введите дробное число типа double: ");
        double doubleValue = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите дробное число типа float: ");
        float floatValue = Convert.ToSingle(Console.ReadLine());

        Console.Write("Введите целое число типа int: ");
        int intValue = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите положительное целое число типа uint: ");
        uint uintValue = Convert.ToUInt32(Console.ReadLine());

        Console.Write("Введите целое число типа long: ");
        long longValue = Convert.ToInt64(Console.ReadLine());

        Console.Write("Введите положительное целое число типа ulong: ");
        ulong ulongValue = Convert.ToUInt64(Console.ReadLine());

        Console.Write("Введите целое число типа short (-32768 - 32767): ");
        short shortValue = Convert.ToInt16(Console.ReadLine());

        Console.Write("Введите положительное целое число типа ushort (0 - 65535): ");
        ushort ushortValue = Convert.ToUInt16(Console.ReadLine());

        Console.WriteLine("\nВы ввели следующие значения:");
        Console.WriteLine("Boolean: " + isTrue);
        Console.WriteLine("Byte: " + byteValue);
        Console.WriteLine("SByte: " + sbyteValue);
        Console.WriteLine("Char: " + charValue);
        Console.WriteLine("Decimal: " + decimalValue);
        Console.WriteLine("Double: " + doubleValue);
        Console.WriteLine("Float: " + floatValue);
        Console.WriteLine("Int: " + intValue);
        Console.WriteLine("UInt: " + uintValue);
        Console.WriteLine("Long: " + longValue);
        Console.WriteLine("ULong: " + ulongValue);
        Console.WriteLine("Short: " + shortValue);
        Console.WriteLine("UShort: " + ushortValue);

        // 1b. Явное и неявное приведение
        int a = 10;
        double b = a;
        long c = a;
        float d = a;
        ushort e = 100;
        int f = e;

        double g = 9.8;
        int h = (int)g;
        long i = 10000;
        short j = (short)i;
        float k = 3.14f;
        int l = (int)k;
        decimal m = 10.5m;
        int n = (int)m;

        // Использование класса Convert
        string s = "123";
        int o = Convert.ToInt32(s);

        // 1c. Упаковка и распаковка
        int num = 123;
        object obj = num; // Упаковка num, obj ссылается на упакованный объект
        int unpackedNum = (int)obj;

        // 1d. Неявно типизированная переменная
        var myVar = 10; // тип myVar - int
        Console.WriteLine("\nТип переменной myVar: " + myVar.GetType());

        // 1e. Nullable переменная
        int? nullableInt = null;
        int? notNullableInt = 5;

        Console.WriteLine(nullableInt == notNullableInt);

        // 1f. Ошибка с переменной var
        // var anotherVar = 10; // тип anotherVar - int
        // anotherVar = "Привет"; // Ошибка: Невозможно присвоить значение другого типа

        // Причина: переменная `anotherVar` имеет тип int, и присвоение строки вызовет ошибку.
    }
}