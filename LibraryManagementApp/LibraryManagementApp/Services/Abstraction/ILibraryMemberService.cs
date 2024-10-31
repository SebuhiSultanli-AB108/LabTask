using LibraryManagementApp.Models;

namespace LibraryManagementApp.Services.Abstraction;

public interface ILibraryMemberService
{
    LibraryMember GetLibraryMembernById(int id);
    LibraryMember GetLibraryMembernByName(string name);
    List<LibraryMember> GetAllLibraryMember();
    void CreateLibraryMember(LibraryMember libraryMember);
    void DeleteLibraryMember(int id);
}

