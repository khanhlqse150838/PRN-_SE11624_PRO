//Lap trinh tao ra cac list employee
namespace Prn.Se1624;
public class Program
{
    static void Main(String[] args)
    {
        //1. create a object(instance)
        Employee e = new Employee();
        e.Id = 1;
        e.Name = "Le Quoc Khanh";
        e.Level = "Junior";
        e.Salary = 5000;
        e.Dob = new DateOnly();
        //create a list employee and filter and display to console
        e.ToString();
        Console.WriteLine(e);
        Console.WriteLine(e.ToString());
        Console.ReadLine();
    }
}
