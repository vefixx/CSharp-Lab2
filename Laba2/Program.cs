using Laba2.Tasks;

namespace Laba2;

class Program
{
    static void Main(string[] args)
    {
        bool isRunning = true;
        
        var task1 = new Task1();
        var task2 = new Task2();
        var task3 = new Task3();
        var task4 = new Task4();
        var task5 = new Task5();

        do
        {
            Console.WriteLine("1) Задача 1.2");
            Console.WriteLine("2) Задача 1.3");
            Console.WriteLine("3) Задача 2.2");
            Console.WriteLine("4) Задача 3.3");
            Console.WriteLine("5) Задача 4.3");
            Console.WriteLine("6) Задача 5.5");
            Console.WriteLine("0) Выход");
            Console.WriteLine();
            Console.Write("Введите номер задачи: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    task1.ExecuteSubtask2();
                    break;
                case "2":
                    task1.ExecuteSubtask3();
                    break;
                case "3":
                    task2.ExecuteSubtask2();
                    break;
                case "4":
                    task3.ExecuteSubtask3();
                    break;
                case "5":
                    task4.ExecuteSubtask8(); 
                    break;
                case "6":
                    task5.ExecuteSubtask5();
                    break;
                case "0":
                    isRunning = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Некорректный ввод");
                    break;
            }

            if (isRunning)
            {
                Console.WriteLine();
                Console.WriteLine("Нажмите любую клавишу для возврата в меню");
                Console.ReadLine();
                Console.Clear();
            }
        } while (isRunning);
    }
}