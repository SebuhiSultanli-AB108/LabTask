using LibraryManagementApp.Exceptions;
using LibraryManagementApp.Models;
using LibraryManagementApp.Services.Abstraction;

namespace LibraryManagementApp.Services.Concretes;

internal class LibraryMemberService : ILibraryMemberService
{
    List<LibraryMember> members = new();
    public void CreateLibraryMember(LibraryMember libraryMember)
    {
        members.Add(libraryMember);
    }

    public void DeleteLibraryMember(int id)
    {
        members.Remove(GetLibraryMembernById(id));
    }

    public List<LibraryMember> GetAllLibraryMember()
    {
        return members;
    }

    public LibraryMember GetLibraryMembernById(int id)
    {
        LibraryMember? libraryMember = members.Find(x => x.Id == id);
        if (libraryMember == null) throw new CustomLibraryMemberException("Cant find the book!");
        return libraryMember;
    }

    public LibraryMember GetLibraryMembernByName(string name)
    {
        LibraryMember? libraryMember = members.Find(x => x.Name == name);
        if (libraryMember == null) throw new CustomLibraryMemberException("Cant find the book!");
        return libraryMember;

    }
}
