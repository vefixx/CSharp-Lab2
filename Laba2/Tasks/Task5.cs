using Laba2.Entities;

namespace Laba2.Tasks;

public class Task5
{
    public Task5()
    {
        
    }
    
    public void ExecuteSubtask5() 
    {
        var f1 = new Drob(1, 2); // 1/2
        var f2 = new Drob(1, 3); // 1/3
        var f3 = new Drob(2, 5); // 2/5

        Console.WriteLine($"{f1} + {f2} = {f1.Sum(f2)}");
        Console.WriteLine($"{f1} + 2 = {f1.Sum(2)}");
        Console.WriteLine($"{f1} - {f2} = {f1.Minus(f2)}");
        Console.WriteLine($"{f1} - 1 = {f1.Minus(1)}");
        Console.WriteLine($"{f1} * {f2} = {f1.Multiply(f2)}");
        Console.WriteLine($"{f1} * 3 = {f1.Multiply(3)}");
        Console.WriteLine($"{f1} / {f2} = {f1.Div(f2)}");
        Console.WriteLine($"{f1} / 2 = {f1.Div(2)}");

        var exampleCalc = new Drob(1, 3).Multiply(new Drob(2, 3));
        Console.WriteLine($"пример: {exampleCalc}");
        
        var finalResult = f1.Sum(f2).Div(f3).Minus(5);

        Console.WriteLine($"{f1} + {f2} / {f3} - 5 = {finalResult}");
    }
}