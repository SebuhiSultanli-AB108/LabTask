namespace LibraryManagementApp.Models;

public sealed class LibraryMember : Person
{
    public DateTime MembershipDate { get; set; }
    private static int _counter;
    public int Id { get; }

    public LibraryMember(string name) : base(name)
    {
        _counter++;
        Id = _counter;
    }
}



