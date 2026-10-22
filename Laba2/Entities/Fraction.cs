namespace Laba2.Entities;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }

    public int Numerator
    {
        get { return _numerator; }
        set { _numerator = value; }
    }

    public int Denominator
    {
        get { return _denominator; }
        set
        {
            if (value == 0)
            {
                int d = IoHelper.ReadInt("Введите корректный знаменатель (> 0): ");
                while (d == 0)
                {
                    d = IoHelper.ReadInt("Введите корректный знаменатель (> 0): ");
                }

                _denominator = d;
            }
            else
            {
                _denominator = value;
            }
        }
    }

    public Fraction Sum(Fraction other)
    {
        // 3/4 + 2/2
        // (3*2/4*2) + (2*4/2*4) = (3*2 + 2*4)/4*2 = (6+8)/8 = 14/8

        // x/y + z/w
        // (x*w/y*w) + (z*y/w*y) = (x*w + z*y)/y*w

        var newFraction = new Fraction((_numerator * other._denominator + other._numerator * _denominator), (_denominator * other._denominator));
        return newFraction;
    }
    
    public Fraction Sum(int num)
    {
        // 3/4 + 2/2
        // (3*2/4*2) + (2*4/2*4) = (3*2 + 2*4)/4*2 = (6+8)/8 = 14/8

        // x/y + z/w
        // (x*w/y*w) + (z*y/w*y) = (x*w + z*y)/y*w

        var other = new Fraction(num, 1);
        var newFraction = new Fraction((_numerator * other._denominator + other._numerator * _denominator), (_denominator * other._denominator));
        return newFraction;
    }

    public Fraction Minus(Fraction other)
    {
        var newFraction = new Fraction((_numerator * other._denominator - other._numerator * _denominator), (_denominator * other._denominator));
        return newFraction;
    }
    
    public Fraction Minus(int num)
    {
        var other = new Fraction(num, 1);
        var newFraction = new Fraction((_numerator * other._denominator - other._numerator * _denominator), (_denominator * other._denominator));
        return newFraction;
    }

    public Fraction Multiply(Fraction other)
    {
        var newFraction = new Fraction(_numerator * other._numerator, _denominator * other._denominator);
        return newFraction;
    }
    
    public Fraction Multiply(int num)
    {
        var other = new Fraction(num, 1);
        var newFraction = new Fraction(_numerator * other._numerator, _denominator * other._denominator);
        return newFraction;
    }

    public Fraction Div(Fraction other)
    {
        var newFraction = new Fraction(_numerator * other._denominator, _denominator * other._numerator);
        return newFraction;
    }
    
    public Fraction Div(int num)
    {
        while (num == 0)
        {
            num = IoHelper.ReadInt("Введите корректное значение (> 0): ");
        }
        
        var other = new Fraction(num, 1);
        var newFraction = new Fraction(_numerator * other._denominator, _denominator * other._numerator);
        return newFraction;
    }

    public override string ToString()
    {
        return $"{_numerator}/{_denominator}";
    }
}