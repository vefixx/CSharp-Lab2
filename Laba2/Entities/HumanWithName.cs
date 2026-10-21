namespace Laba2.Entities;

public class HumanWithName
{
    private Name _name;
    private int _height;

    public HumanWithName(Name name, int height)
    {
        _name = name;
        Height = height;
    }

    public int Height
    {
        get { return _height; }
        set
        {
            if (value > 0)
            {
                _height = value;
            }
            else
            {
                int h = IoHelper.ReadInt("Введите корректный возраст (> 0): ");
                while (h <= 0)
                {
                    h = IoHelper.ReadInt("Введите корректный возраст (> 0): ");
                }

                _height = h;
            }
        }
    }

    public override string ToString()
    {
        return $"{_name}, рост: {_height}";
    }
}