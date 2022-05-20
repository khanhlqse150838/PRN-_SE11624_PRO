namespace Prn.Se1624;
public class Employee
{
    /*Define field (data)*/
    private int _id;
    private string _name;
    private DateOnly _dob;

    /*Define Properties*/
    public float Salary { get; set; }
    public string Level { get; set; }
    public string Name { get { return _name; } set { _name = value; } }
    public int Id { get { return _id; } set { _id = value; } }

    public DateOnly Dob { get => _dob; set => _dob = value; }

    /*Constructor*/
    public Employee(float salary, string level, int id, string name, DateOnly dob)
    {
        Salary = salary;
        Level = level;
        Id = id;
        Name = name;
        Dob = dob;
     }

    public Employee()
    {
    }

    public override string? ToString()
    {
        return GetString();
    }

    private string GetString()
    {
        return $"[Id = {this._id}, Name = {Name}, Dob = {this._dob}], Level = {Level}, Salary = {Salary}";
    }


}