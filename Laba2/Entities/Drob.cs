namespace Laba2.Entities;

public class Drob
{
    private int _chisl;
    private int _znam;

    public Drob(int chisl, int znam)
    {
        Chisl = chisl;
        Znam = znam;
    }

    public int Chisl
    {
        get { return _chisl; }
        set { _chisl = value; }
    }

    public int Znam
    {
        get { return _znam; }
        set
        {
            if (value == 0)
            {
                int z = IoHelper.ReadInt("Введите корректный знаменатель (> 0): ");
                while (z == 0)
                {
                    z = IoHelper.ReadInt("Введите корректный знаменатель (> 0): ");
                }

                _znam = z;
            }
            else
            {
                _znam = value;
            }
        }
    }

    public Drob Sum(Drob other)
    {
        // 3/4 + 2/2
        // (3*2/4*2) + (2*4/2*4) = (3*2 + 2*4)/4*2 = (6+8)/8 = 14/8

        // x/y + z/w
        // (x*w/y*w) + (z*y/w*y) = (x*w + z*y)/y*w

        var newDrop = new Drob((_chisl * other._znam + other._chisl * _znam), (_znam * other._znam));
        return newDrop;
    }
    
    public Drob Sum(int num)
    {
        // 3/4 + 2/2
        // (3*2/4*2) + (2*4/2*4) = (3*2 + 2*4)/4*2 = (6+8)/8 = 14/8

        // x/y + z/w
        // (x*w/y*w) + (z*y/w*y) = (x*w + z*y)/y*w

        var other = new Drob(num, 1);
        var newDrop = new Drob((_chisl * other._znam + other._chisl * _znam), (_znam * other._znam));
        return newDrop;
    }

    public Drob Minus(Drob other)
    {
        var newDrop = new Drob((_chisl * other._znam - other._chisl * _znam), (_znam * other._znam));
        return newDrop;
    }
    
    public Drob Minus(int num)
    {
        var other = new Drob(num, 1);
        var newDrop = new Drob((_chisl * other._znam - other._chisl * _znam), (_znam * other._znam));
        return newDrop;
    }

    public Drob Multiply(Drob other)
    {
        var newDrop = new Drob(_chisl * other._chisl, _znam * other._znam);
        return newDrop;
    }
    
    public Drob Multiply(int num)
    {
        var other = new Drob(num, 1);
        var newDrop = new Drob(_chisl * other._chisl, _znam * other._znam);
        return newDrop;
    }

    public Drob Div(Drob other)
    {
        var newDrop = new Drob(_chisl * other._znam, _znam * other._chisl);
        return newDrop;
    }
    
    public Drob Div(int num)
    {
        while (num == 0)
        {
            num = IoHelper.ReadInt("Введите корректное значение (> 0): ");
        }
        
        var other = new Drob(num, 1);
        var newDrop = new Drob(_chisl * other._znam, _znam * other._chisl);
        return newDrop;
    }

    public override string ToString()
    {
        return $"{_chisl}/{_znam}";
    }
}