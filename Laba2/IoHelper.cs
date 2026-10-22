using Microsoft.VisualBasic.CompilerServices;

namespace Laba2;

public class IoHelper
{
    public IoHelper()
    {
        
    }

    public static int ReadInt(string prompt)
    {
        int value;
        while (!int.TryParse(ReadNotEmptyString(prompt), out value))
        {
            Console.Write($"Ошибка!");
        }

        return value;
    }
    
    /// <summary>
    /// Считывает строку из консоли, пока пользователь не введет любое значение
    /// </summary>
    /// <param name="prompt"></param>
    /// <returns></returns>
    public static string ReadNotEmptyString(string prompt)
    {
        string input;
        while (true)
        {
            Console.Write(prompt);
            input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.Write("Ошибка! Пустая строка.");
            }
            else
            {
                break;
            }
        }

        return input;
    }
    
    /// <summary>
    /// Последовательно считывает значения пользователя из консоли для формирования массива
    /// </summary>
    /// <param name="length"></param>
    /// <returns></returns>
    public static int[] ReadIntArray(int length)
    {
        int[] arr = new int[length];

        int i = 0;
        int value;
        string input;
        while (i < length)
        {
            input = ReadNotEmptyString($"Введите число №{i + 1}: ");
            
            if (!int.TryParse(input, out value))
            {
                Console.Write("Ошибка! Некорректное значение.");
            }
            else
            {
                arr[i] = value;
                i++;
            }
        }

        return arr;
    }

    public static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(", ", arr));
    }
}