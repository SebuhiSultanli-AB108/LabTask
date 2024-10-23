namespace StudentStatusEnum.Models;

public interface IStudentService
{
    Student GetStudentById(int id);
    Student[] GetStudentsByName(string name);
    void AddStudent(Student student);
    void UpdateStudent(int id, Student student);
    void RemoveStudent(int id, bool isSoftDelete);
    void GetAllStudents();
}