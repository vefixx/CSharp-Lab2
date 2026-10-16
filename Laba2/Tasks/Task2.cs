using Laba2.Entities;

namespace Laba2.Tasks;

public class Task2
{
    public Task2()
    {
        
    }

    public void ExecuteSubtask2()
    {
        var h1 = new HumanWithName(new Name("", "Клеопатра", ""), 152);
        var h2 = new HumanWithName(new Name("Пушкин", "Александр", "Сергеевич"), 167);
        var h3 = new HumanWithName(new Name("Маяковский", "Владимир", ""), 189);

        Console.WriteLine(h1);
        Console.WriteLine(h2);
        Console.WriteLine(h3);
    }
}