namespace StudentStatusEnum.Models;

public class Student
{
    public int Id { get; }
    static int count = 0;
    public Student()
    {
        if (count > 999) Console.WriteLine("Student List Is Full!");
        else Id = count++;
    }

    private string _firstName;
    private string _lastName;
    private string _email;
    private string _phoneNumber;
    private double _gpa;
    private string _major;
    public string FirstName
    {
        get => _firstName;
        set
        {
            if (value.Length < 12) _firstName = value;
            else Error(12);
        }
    }
    public string LastName
    {
        get => _lastName;
        set
        {
            if (value.Length < 15) _lastName = value;
            else Error(15);

        }
    }
    public string Email
    {
        get => _email;
        set
        {
            if (value.Length < 32) _email = value;
            else Error(32);
        }
    }
    public string PhoneNumber
    {
        get => _phoneNumber;
        set
        {
            if (value.Length < 12) _phoneNumber = value;
            else Error(12);
        }
    }
    public double GPA
    {
        get => _gpa;
        set
        {
            if (value < 1000) _gpa = value;
            else Error(999);
        }
    }
    public StudentStatus Status { get; set; }
    public string Major
    {
        get => _major;
        set
        {
            if (value.Length < 25) _major = value;
            else Error(25);
        }
    }

    private void Error(int max)
    {
        Console.WriteLine($"Input is too long! Max length is: {max}");
    }
}
