using LibraryManagementApp.Exceptions;
using LibraryManagementApp.Models;
using LibraryManagementApp.Services.Abstraction;

namespace LibraryManagementApp.Services.Concretes;

internal class LibrarianService : ILibrarianService
{
    List<Librarian> librarians = new();

    public void CreateLibrarian(Librarian librarian)
    {
        librarians.Add(librarian);
    }

    public void DeleteLibrarian(int id)
    {
        librarians.Remove(GetLibrarianById(id));
    }

    public List<Librarian> GetAllLibrarian()
    {
        return librarians;
    }

    public Librarian GetLibrarianById(int id)
    {
        Librarian? librarian = librarians.Find(x => x.Id == id);
        if (librarian == null) throw new CustomLibrarianException("Cant find the librarian!");
        return librarian;
    }

    public Librarian GetLibrarianByName(string name)
    {
        Librarian? librarian = librarians.Find(x => x.Name == name);
        if (librarian == null) throw new CustomLibrarianException("Cant find the librarian!");
        return librarian;
    }
}
