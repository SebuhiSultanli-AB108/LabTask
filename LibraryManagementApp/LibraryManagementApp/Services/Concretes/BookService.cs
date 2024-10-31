using LibraryManagementApp.Exceptions;
using LibraryManagementApp.Models;
using LibraryManagementApp.Services.Abstraction;

namespace LibraryManagementApp.Services.Concretes;

internal class BookService : IBookService
{
    List<Book> books = new();
    public void CreateBook(Book book)
    {
        books.Add(book);
    }

    public void DeleteBook(int id)
    {
        books.Remove(GetBookById(id));
    }

    public List<Book> GetAllBook()
    {
        return books;
    }

    public Book GetBookById(int id)
    {
        Book? book = books.Find(x => x.Id == id);
        if (book == null) throw new CustomLibraryItemException("Cant find the book!");
        return book;
    }

    public Book GetBookByTitle(string title)
    {
        Book? book = books.Find(x => x.Title == title);
        if (book == null) throw new CustomLibraryItemException("Cant find the book!");
        return book;
    }
}
