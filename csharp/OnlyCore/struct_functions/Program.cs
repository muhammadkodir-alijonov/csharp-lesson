namespace struct_functions;

public class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        student.FirstName = "Test";
        student.LastName = "Test1";
        student.GetAge(12);
        student.PutAge(13);
    }

    struct Student
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public void GetAge(int yosh)
        {
            Age = yosh;
        }
        public void PutAge(int age)
        {
            Age = age;
        }
    }
}