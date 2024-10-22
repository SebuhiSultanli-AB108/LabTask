namespace Models;

public  class Manager
{
    private protected Employee GetPromotion(Employee employee)
    {
        employee.Salary += 100;
        return employee;
    }
}

public class Assistant : Manager
{
    public void GetFeedBack(Employee employee)
    {
        if (employee.IsSuccessful) GetPromotion(employee);
    }
}

public class Employee
{
    private string _name ;
    private bool _isSuccessful;
    private float _salary;

    public Employee(string name, bool isSuccessful, float salary)
    {
        Name = name;
        IsSuccessful = isSuccessful;
        Salary = salary;
    }

    public string Name { get { return _name; } set { _name = value; } }
    public bool IsSuccessful { get { return _isSuccessful; } set { _isSuccessful = value; } }
    public float Salary { get { return _salary; } set { _salary = value; } }
}
