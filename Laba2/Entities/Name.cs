namespace Laba2.Entities;

public class Name
{
    private string _lastName;
    private string _firstName;
    private string _middleName;

    public Name(string lastName, string firstName, string middleName)
    {
        _lastName = lastName;
        _firstName = firstName;
        _middleName = middleName;
    }

    public string LastName
    {
        get
        {
            return _lastName;
        }
        set
        {
            _lastName = value;
        }
    }
    
    public string FirstName
    {
        get
        {
            return _firstName;
        }
        set
        {
            _firstName = value;
        }
    }
    
    public string MiddleName
    {
        get
        {
            return _middleName;
        }
        set
        {
            _middleName = value;
        }
    }

    public override string ToString()
    {
        string s = "";
        
        if (!string.IsNullOrEmpty(_lastName))
        {
            s += _lastName;
        }

        if (!string.IsNullOrEmpty(_firstName))
        {
            s += $" {_firstName}";
        }
        
        if (!string.IsNullOrEmpty(_middleName))
        {
            s += $" {_middleName}";
        }

        return s.Trim();
    }
}