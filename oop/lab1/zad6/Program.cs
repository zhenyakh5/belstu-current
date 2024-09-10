using System;

class Program
{
    static void Main()
    {
        TestChecked();
        TestUnchecked();
    }

    static void TestChecked()
    {
        void CheckedFunction()
        {
            try
            {
                int maxValue = int.MaxValue;
                // Проверка на переполнение с помощью checked
                int result = checked(maxValue + 1);
                Console.WriteLine($"Результат с проверкой: {result}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        CheckedFunction();
    }

    static void TestUnchecked()
    {
        void UncheckedFunction()
        {
            // Проверка на переполнение без проверки с помощью unchecked
            int maxValue = int.MaxValue;
            int result = unchecked(maxValue + 1);
            Console.WriteLine($"Результат без проверки: {result}");
        }

        UncheckedFunction();
    }
}
