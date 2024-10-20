using ClassLibrary1;

namespace ModelDLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Ferid", 1500);
            Assistant assistant = new Assistant();

            assistant.GetFeedback(employee);
            Console.WriteLine(employee.Salary);

            employee.IsSuccessfull = true;
            assistant.GetFeedback(employee);
            Console.WriteLine(employee.Salary);
        }
    }
}
