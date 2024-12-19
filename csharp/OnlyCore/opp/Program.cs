namespace base_sealed
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Staff staff = new Staff("", "", "");
            //Console.WriteLine(staff.Firstname);
            Child child = new Child("salom",12);

        }
    }

    public abstract class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public Person(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }
    }
    public class Staff : Person
    {
        public string Job { get; set; }

        public Staff(string job, string firstname, string lastname)
            : base(firstname, lastname)
        {
            Job = job;
        }
    }

    /*public class Teacher : Staff
    {
        public string[] Subjects { get; set; } = new string[3];

        public Teacher(string[] subjects, string job, string firstname, string lastname)
            : base(job, firstname, lastname)
        {
            Subjects = subjects;
        }
    }*/
}

class Base
{
    public string Name { get; set; }
    public Base(string name)
    {
        Name = name;
    }
}
class Child : Base
{
    public int Age { get; set; }
    public Child(string name, int age) : base(name)
    {
        Age = age;
    }

}