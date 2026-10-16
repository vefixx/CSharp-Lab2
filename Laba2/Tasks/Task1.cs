using Laba2.Entities;

namespace Laba2.Tasks;

public class Task1
{
    public Task1()
    {
        
    }

    public void ExecuteSubtask2()
    {
        var human1 = new Human("Клеопатра", 152);
        var human2 = new Human("Пушкин", 167);
        var human3 = new Human("Владимир", 189);

        Console.WriteLine(human1);
        Console.WriteLine(human2);
        Console.WriteLine(human3);
    }

    public void ExecuteSubtask3()
    {
        var name1 = new Name("", "Клеопатра", "");
        var name2 = new Name("Пушкин", "Александр", "Александрович");
        var name3 = new Name("Маяковский", "Владимир", "");

        Console.WriteLine(name1);
        Console.WriteLine(name2);
        Console.WriteLine(name3);
    }
}