using Laba2.Entities;

namespace Laba2.Tasks;

public class Task4
{
    public Task4()
    {
        
    }

    public void ExecuteSubtask8()
    {
        var cityA = new City2("A");
        var cityB = new City2("B");
        var cityC = new City2("C");
        var cityD = new City2("D");
        var cityE = new City2("E");
        var cityF = new City2("F");

        Dictionary<City2, int> pathsA = new Dictionary<City2, int>
        {
            { cityF, 1 },
            { cityD, 6 }
        };

        Dictionary<City2, int> pathsB = new Dictionary<City2, int>
        {
            { cityA, 5 }
        };

        Dictionary<City2, int> pathsC = new Dictionary<City2, int>
        {
            { cityB, 3 }
        };

        Dictionary<City2, int> pathsD = new Dictionary<City2, int>
        {
            { cityC, 4 },
            { cityA, 6 }
        };

        Dictionary<City2, int> pathsE = new Dictionary<City2, int>
        {
            { cityD, 2 }
        };

        Dictionary<City2, int> pathsF = new Dictionary<City2, int>
        {
            { cityB, 1 },
            { cityE, 2 }
        };

        cityA = new City2("A", pathsA);
        cityB = new City2("B", pathsB);
        cityC = new City2("C", pathsC);
        cityD = new City2("D", pathsD);
        cityE = new City2("E", pathsE);
        cityF = new City2("F", pathsF);

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