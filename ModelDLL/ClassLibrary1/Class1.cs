namespace ClassLibrary1;

public class Manager
{
    protected Employee GetPromotion(Employee employee)
    {
        employee.Salary += 100;
        return employee;
    }
}

public class Assistant : Manager
{
    public Employee GetFeedback(Employee employee)
    {
        if (employee.IsSuccessfull)
        {
            GetPromotion(employee);
        }
        return employee;
    }
}

public class Employee
{
    private string _name;
    private double _salary;
    private bool _isSuccessfull = false;


    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public double Salary
    {
        get { return _salary; }
        set { _salary = value; }
    }

    public bool IsSuccessfull
    {
        get { return _isSuccessfull; }
        set { _isSuccessfull = value; }
    }


    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }
}