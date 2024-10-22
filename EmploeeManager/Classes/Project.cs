namespace EmploeeManager.Classes;

public class Project
{
    /*
    Project
        - Id
        -Employees[]
        -Starttimes
        -Deadline
        -IsSuccessfull 
        -AssignEmployee() - Employee object qəbul edəcək proyekte employee assign olunacaq
        -RemoveEmployee() - proyektdən employee çıxarılacaq(həmçinin employee obyektindəki projects array-dən bu proyektin adı silinəcək)id qəbul edəcək
        -Finish() - metodunu çağırdıqda indiki vaxt start time ile deadline time arasındadırsa(yəni deadline-ı keçməyibsə) isSuccesful dəyəri true olsun 
        -Print() - metodu proyektin bütün məlumatlarını consola çıxartsın
        Project obyekti starttime və deadline dəyərlərini qəbul etmədən yarana bilməz
    */

    private int _id;
    private Employee[] _employees;
    private string _deadLine;
    private bool _isSuccessful;

    public int Id { get { return _id; } set { _id = value; } }
    public Employee[] Employees { get { return _employees; } set { _employees = value; } }
    public string DeadLine { get { return _deadLine; } set { _deadLine = value; } }
    public bool IsSuccessful { get { return _isSuccessful; } set { _isSuccessful = value; } }

    public Project(int id, Employee[] employees, string deadline, bool isSuccessful)
    {
        Id = id;
        Employees = employees;
        DeadLine = deadline;
        IsSuccessful = isSuccessful;
    }

    public void AssignEmployee(Employee employee, int id)
    {
        for (int i = 0; i < Employees.Length; i++)
        {
            if (Employees[i].Id == id) Employees[i] = employee;
        }
    }

    public void RemoveEmployee(Employee employee, int id)
    {
        for (int i = 0; i < Employees.Length; i++)
        {
            if (Employees[i].Id == id) Employees[i] = null;
        }
    }
}
