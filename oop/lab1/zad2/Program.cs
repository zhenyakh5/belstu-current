using System;
using System.Text;

class Program
{
    static void Main()
    {
        // 2a. Объявление строковых литералов и их сравнение
        string str1 = "Hello";
        string str2 = "World";
        string str3 = "Hello";

        Console.WriteLine("Сравнение str1 и str2: " + str1.Equals(str2)); // false
        Console.WriteLine("Сравнение str1 и str3: " + str1.Equals(str3)); // true

        // 2b. Операции со строками на основе класса String
        string s1 = "Привет";
        string s2 = "мир";
        string s3 = "C#";

        string concatenatedString = string.Concat(s1, " ", s2, " ", s3);
        Console.WriteLine("\nСцепленная строка: " + concatenatedString);

        string copiedString = string.Copy(s1);
        Console.WriteLine("Копия строки: " + copiedString);

        string substring = s1.Substring(0, 4); // с 0, длина 4
        Console.WriteLine("Подстрока: " + substring);

        string sentence = "Это пример строки для разделения";
        string[] words = sentence.Split(' ');
        Console.WriteLine("Разделенные слова:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        string insertedString = s1.Insert(6, " мой"); // с 6
        Console.WriteLine("Строка с вставленной подстрокой: " + insertedString);

        string removedString = s1.Remove(2, 3); // с 2, длина 3
        Console.WriteLine("Строка с удаленной подстрокой: " + removedString);

        string interpolatedString = $"{s1}, {s2}! Это {s3} программа.";
        Console.WriteLine("Интерполированная строка: " + interpolatedString);

        // 2c. Работа с пустыми и null строками
        string emptyString = "";
        string nullString = null;

        Console.WriteLine("\nemptyString is null or empty: " + string.IsNullOrEmpty(emptyString)); // true
        Console.WriteLine("nullString is null or empty: " + string.IsNullOrEmpty(nullString)); // true

        if (!string.IsNullOrEmpty(emptyString))
        {
            Console.WriteLine("Это непустая строка.");
        }
        else
        {
            Console.WriteLine("Пустая строка.");
        }

        if (nullString != null)
        {
            Console.WriteLine("Это не null строка.");
        }
        else
        {
            Console.WriteLine("Это null строка.");
        }

        // 2d. Работа со строками на основе StringBuilder (неизмен. строка символов)
        StringBuilder sb = new StringBuilder("Hello, World!");

        sb.Remove(5, 7); // Удаление ", World"
        Console.WriteLine("\nСтрока после удаления: " + sb.ToString());

        sb.Insert(0, "Start: ");
        sb.Append(" :End");
        Console.WriteLine("Строка после добавления: " + sb.ToString());
    }
}
