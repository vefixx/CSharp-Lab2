using Microsoft.VisualBasic.CompilerServices;

namespace Laba2;

public class Validator
{
    public Validator()
    {
        
    }

    public int ReadInt(string prompt)
    {
        int value;
        while (!int.TryParse(ReadNotEmptyString(prompt), out value))
        {
            Console.Write($"Ошибка! ");
        }

        return value;
    }

    public string ReadNotEmptyString(string prompt)
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

    public int[] ReadIntArray(int length)
    {
        int[] arr = new int[length];

        int i = 0;
        while (i < length)
        {
            string input = ReadNotEmptyString($"Введите число №{i + 1}: ");
            
            int value;
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
}