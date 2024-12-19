static void Main()
{
    Person p = new Person { Name = "Tom" };
    p.Display();
    p = new Employee { Name = "Sam" };
    p.Display();
    Console.WriteLine();
}
class Person
{
    private string _name;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public void Display()
    {
        Console.WriteLine(Name);
    }
}
class Employee : Person
{

}