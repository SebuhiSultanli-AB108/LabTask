using EmploeeManager.Classes;

namespace EmploeeManager;

public class Employee
{
    /*
     Emplpyees
        -Id
        -FullName
        -Projects[]
        -Leave() - projectin id-sini qebul edecek , həmin proyekt , projects array-dən silinecek həmçinin project obyektinin özündə saxladığı employees array-dən silinəcək
     */

    private int _id;
    private string _fullName;
    private Project[] _projects;

    public int Id { get { return _id; } set { _id = value; } }
    public string FullName { get { return _fullName; } set { _fullName = value; } }
    public Project[] Projects { get { return _projects; } set { _projects = value; } }

    public Employee(int id, string fullName, Project[] projects)
    {
        Id = id;
        FullName = fullName;
        Projects = projects;
    }

    public void Leave(int id)
    {

    }
}
