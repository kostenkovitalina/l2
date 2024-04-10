using System;

class Program
{
    static void Main()
    {
        int[] array = null; // Ініціалізуємо масив

        while (true)
        {
            Console.WriteLine("\nГоловне меню:");
            Console.WriteLine("1. Створити масив, заповнивши випадково");
            Console.WriteLine("2. Створити масив, заповнивши з клавіатури");
            Console.WriteLine("3. Виконати варіант студента Ааа");
            Console.WriteLine("4. Виконати варіант студента Ббб");
            Console.WriteLine("5. Виконати варіант студента Ввв");
            Console.WriteLine("6. Вивести поточний стан масиву");
            Console.WriteLine("7. Повернутися у головне меню до вибору блоку");
            Console.WriteLine("8. Вийти з програми");

            Console.Write("\nВиберіть опцію: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    array = CreateRandomArray();
                    break;
                case "2":
                    array = CreateArrayFromInput();
                    break;
                case "3":
                    ExecuteStudentVariant("XXX", "Ааа", array); // Замість "XXX" введіть фактичний номер варіанту
                    break;
                case "4":
                    ExecuteStudentVariant("YYY", "Ббб", array); // Замість "YYY" введіть фактичний номер варіанту
                    break;
                case "5":
                    ExecuteStudentVariant("ZZZ", "Ввв", array); // Замість "ZZZ" введіть фактичний номер варіанту
                    break;
                case "6":
                    PrintArray(array);
                    break;
                case "7":
                    // Нічого не робимо, просто продовжуємо цикл
                    break;
                case "8":
                    return; // Завершуємо програму
                default:
                    Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                    break;
            }
        }
    }

    static int[] CreateRandomArray()
    {
        Console.Write("Введіть розмір масиву: ");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(100); // Заповнюємо масив випадковими числами від 0 до 99
        }
        Console.WriteLine("Масив, заповнений випадково, створений успішно.");
        return array;
    }

    static int[] CreateArrayFromInput()
    {
        Console.Write("Введіть розмір масиву: ");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];
        Console.WriteLine("Введіть елементи масиву:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Елемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Масив, заповнений з клавіатури, створений успішно.");
        return array;
    }

    static void ExecuteStudentVariant(string variantNumber, string studentName, int[] array)
    {
        // Виконати варіант студента з номером variantNumber та прізвищем studentName
        Console.WriteLine($"Виконується варіант студента {studentName} (варіант {variantNumber})...");
        // Додайте сюди код для виконання варіанту студента
    }

    static void PrintArray(int[] array)
    {
        if (array == null)
        {
            Console.WriteLine("Масив ще не створено.");
            return;
        }

        Console.WriteLine("Поточний стан масиву:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Елемент {i + 1}: {array[i]}");
        }
    }
}
