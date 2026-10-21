using System.Text;

namespace Laba2.Entities;

public class City2
{
    private string _name;
    private Dictionary<City2, int> _paths;

    public City2(string name)
    {
        Name = name;
        _paths = new Dictionary<City2, int>();
    }

    public City2(string name, Dictionary<City2, int> cities)
    {
        Name = name;
        _paths = cities;
    }

    public void AddPath(City2 city, int cost)
    {
        _paths[city] = cost;
    }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        
        if (_paths.Count > 0)
        {
            foreach (KeyValuePair<City2, int> path in _paths)
            {
                stringBuilder.Append($"{path.Key._name}:{path.Value}\n");
            }
        }

        return stringBuilder.ToString();
    }

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (!string.IsNullOrEmpty(value)
                && !string.IsNullOrWhiteSpace(value))
            {
                _name = value;
            }
            else
            {
                string n = IoHelper.ReadNotEmptyString("Введите корректное имя города: ");
                _name = n;
            }
        }
    }
}