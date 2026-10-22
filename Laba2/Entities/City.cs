using System.Text;

namespace Laba2.Entities;

public class City
{
    private string _name;
    private Dictionary<City, int> _paths;

    public City(string name)
    {
        Name = name;
        _paths = new Dictionary<City, int>();
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

    public Dictionary<City, int> Paths
    {
        get { return _paths; }
        set { _paths = value; }
    }
    
    public void AddPath(City city, int cost)
    {
        _paths[city] = cost;
    }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        
        if (_paths.Count > 0)
        {
            foreach (KeyValuePair<City, int> path in _paths)
            {
                stringBuilder.Append($"{path.Key._name}:{path.Value}\n");
            }
        }

        return stringBuilder.ToString();
    }
}