namespace LibraryManagementApp.Exceptions;


public class CustomLibraryMemberException : Exception
{
    public CustomLibraryMemberException() : base("There is a Member Exception")
    {

    }

    public CustomLibraryMemberException(string message) : base(message)
    {
    }


}