namespace Table;

internal class Colum
{
    private int _age;
    private string _name;
    private string _surname;

    readonly int AgeMax = 3;
    readonly int NameMax = 12;
    readonly int SurnameMax = 15;

    public Colum(string name, string surname, int age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }


    public int Age
    {
        get { return _age; }
        set
        {
            if (value.ToString().Length <= AgeMax) _age = value;
            else Console.WriteLine($"Length of age must be less than {AgeMax}!");
        }
    }
    public string Name
    {
        get { return _name; }
        set
        {
            if (value.Length <= NameMax) _name = value;
            else Console.WriteLine($"Length of name must be less than {NameMax}!");
        }
    }
    public string Surname
    {
        get { return _surname; }
        set
        {
            if (value.Length <= SurnameMax) _surname = value;
            else Console.WriteLine($"Length of surname must be less than {SurnameMax}!");
        }
    }
}