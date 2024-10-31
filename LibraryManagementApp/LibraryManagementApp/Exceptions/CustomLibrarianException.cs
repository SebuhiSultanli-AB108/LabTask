namespace LibraryManagementApp.Exceptions;


public class CustomLibrarianException : Exception
{
    public CustomLibrarianException() : base("There is a Librarian Exception")
    {

    }

    public CustomLibrarianException(string message) : base(message)
    {
    }


}