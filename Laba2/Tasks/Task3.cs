using Laba2.Entities;

namespace Laba2.Tasks;

public class Task3
{
    public Task3()
    {
        
    }

    public void ExecuteSubtask3()
    {
        City cityA = new City("A");
        City cityB = new City("B");
        City cityC = new City("C");
        City cityD = new City("D");
        City cityE = new City("E");
        City cityF = new City("F");

        cityA.AddPath(cityD, 6);
        cityA.AddPath(cityF, 1);
        cityA.AddPath(cityB, 5);
        
        cityF.AddPath(cityB, 1);
        cityF.AddPath(cityE, 2);
        
        cityB.AddPath(cityA, 5);
        cityB.AddPath(cityC, 3);
        
        cityE.AddPath(cityF, 2);
        
        cityD.AddPath(cityA, 6);
        cityD.AddPath(cityE, 2);
        cityD.AddPath(cityC, 4);
        
        cityC.AddPath(cityB, 3);
        cityC.AddPath(cityD, 4);

        Console.WriteLine("Города и пути:");
        
        Console.WriteLine("A:");
        Console.WriteLine(cityA);
        
        Console.WriteLine("B:");
        Console.WriteLine(cityB);
        
        Console.WriteLine("C:");
        Console.WriteLine(cityC);
        
        Console.WriteLine("D:");
        Console.WriteLine(cityD);
        
        Console.WriteLine("E:");
        Console.WriteLine(cityE);
        
        Console.WriteLine("F:");
        Console.WriteLine(cityF);
    }
}