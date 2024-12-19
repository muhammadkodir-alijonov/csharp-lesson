using System.Collections;
using System.Xml.Linq;

namespace Linq;

public class Program

{
    private static IList<Student> Students = new List<Student>()
    {
        new Student()
        {
            Id =1,
            FirstName = "Ali.",
            LastName = "Vali.",
            PhoneNumber = "+9989412312321",
            CourseId = 1,

        },
        new Student()
        {
            Id =2,
            FirstName = "Soli",
            LastName = "qoli",
            PhoneNumber = "+99894123782321",
            CourseId = 2,

        },
        new Student()
        {
            Id =3,
            FirstName = "avaz",
            LastName = "jabboraliyev",
            PhoneNumber = "+99894123123234",
            CourseId = 3,

        },
        new Student()
        {
            Id =4,
            FirstName = "avaz",
            LastName = "Vali",
            PhoneNumber = "+9989412312321",
            CourseId = 3,

        },
        new Student()
        {
            Id =5,
            FirstName = "Dilshod",
            LastName = "Tursuniv",
            PhoneNumber = "+998941435321",
            CourseId = 4,

        }
    };
   /* private static IList<Course> Courses = new List<Course>()
    {
        new Course()
        {
            Id = 1,
            Name = ".net bootcamp-"
        },
    new Course()
    {
        Id = 2,
            Name = "Flutter bootcamp-"
        },
    new Course()
    {
        Id = 3,
            Name = "Java bootcamp--"
        },
    new Course()
    {
        Id = 4,
            Name = " bootcamp-"
        }
};*/
    /*private static IList<Person> People = new List<Person>()
    {
        new Person()
        {
            FirstName = "Muhammad",
            LastName = "alijonov",
            Address = "Namangan",
            Age = 20,
            PhoneNumber = "+998945040608",
            Job = "Developer"
        },
        new Person()
        {
            FirstName = "Qahhor",
            LastName = "Xurramov",
            Address = "Surxandaryo",
            Age = 21,
            PhoneNumber = "+998935040448",
            Job = "Waiter"
        },
        new Person()
        {
            FirstName = "Asror",
            LastName = "Abdullayev",
            Address = "Namangan",
            Age = 22,
            PhoneNumber = "+998945040341",
            Job = "Scientest"
        }

    };*/
    static void Main(string[] args)
    {
        /*//string[] arr = { "salom", "hayir", "muhammad", "avaz", "guli"};
        //arr = arr.OrderByDescending(x => x).ToArray();
        //foreach (string s in arr)
        //{
        //    Console.WriteLine(s);
        //}

        //string[] arr = { "salom", "hayir", "muhammad", "avaz", "guli" };

        //var arr2 = from item in arr
        //           where item.Contains("m")
        //           select item;
        //foreach (var item in arr2)
        //{
        //    Console.WriteLine(item);
        //}*/

        /*var ucellPhone = People.Where(x => (x.PhoneNumber.StartsWith("+99894") 
        || x.PhoneNumber.StartsWith("+99893" )) && x.Age == 20);

        foreach (var person in ucellPhone)
        {
            Console.WriteLine(person.FirstName + " " + person.LastName);
        }*/

        /* ArrayList arrayList = new ArrayList();
        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add(3);
        arrayList.Add(4);
        arrayList.Add(5);
        arrayList.Add(true);
        arrayList.Add("salom");
        arrayList.Add("dunyo");
        arrayList.Add("Muhammad");
        arrayList.Add(10);
        arrayList.Add(13);

        var query = from human in People
                    orderby human.Age descending
                    select human;
        foreach (var human in query)
        {
            Console.WriteLine($"{human.LastName} {human.FirstName}");
        }



        var query1 = People.OrderBy(x => x.FirstName)
            .ThenByDescending(x => x.Age);

        foreach (var person in query1)
            Console.WriteLine(person.FirstName + " " + person.Age);
        


        var humans = People.GroupBy(x => x.Job);
        foreach (var groupHuman in humans)
        {
            Console.WriteLine($"/----> {groupHuman.Key} - {groupHuman.Count()}");
            foreach (var human in groupHuman)
            {
                Console.WriteLine($"{human.FirstName} {human.LastName}");
            }
        }

        */

        /*//IEnumerable<int> collection = new List<int>()
        //{
        //    1,2,3,4,5,61,6,7,8,9
        //};
        //var result = collection.ElementAtOrDefault(123412);
        //Console.WriteLine(result);

        //IEnumerable<int> collection = new List<int>()
        //{
        //    1,2,3,4,5,61,6,7,8,9
        //};
        //var result = collection.FirstOrDefault(x => x%2 == 0);
        //Console.WriteLine(result);

        //IEnumerable<int> collection = new List<int>()
        //{
        //    1,2,3,4,5,61,6,7,8,9
        //};
        //var result = collection.LastOrDefault(x => x % 2 == 0);
        //Console.WriteLine(result);

        //var list1 = new List<int>()
        //{
        //    1, 2, 3, 4, 5, 
        //};
        //var list2 = new List<int>()
        //{
        //    1, 2, 3,4,5,6
        //};

        //Console.WriteLine(list1.SequenceEqual(list2));//false



        //IEnumerable<int> list1 = new List<int>()
        //{
        //    1, 2, 3, 4, 5,
        //};
        //IEnumerable<int> list2 = new List<int>()
        //{
        //    1, 2, 3,4,5,6
        //};

        //list1 = list1.Concat(list2);

        //foreach (var i in list1)
        //{
        //    Console.WriteLine(i);
        //}

        //IEnumerable<int> list1 = new List<int>()
        //{
        //    1, 2, 3, 4, 5,
        //};

        //list1 = list1.DefaultIfEmpty(5);

        //foreach (int i in list1)
        //{
        //    Console.WriteLine(i);
        //}

        //IEnumerable<int> list = Enumerable.Range(0, 1000);
        //foreach (int i in list)
        //{
        //    Console.WriteLine(i);
        //}

        //IEnumerable<int> list = Enumerable.Repeat(0, 1000);
        //foreach (int i in list)
        //{
        //    Console.WriteLine(i);
        //}



        //IEnumerable<int> list = new List<int> { 2,5,2, 5,3,1, 2, 3, 4, 5, 6, 7, 8, 9 };

        //list = list.Distinct();
        //foreach (int i in list)
        //{
        //    Console.WriteLine(i);
        //}



        //IEnumerable<int> list = new List<int> { 2, 5, 2, 5, 3, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        //var result = list.Skip(5);

        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}


        //IEnumerable<int> list = new List<int> { 2, 5, 2, 5, 3, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //var result = list.Take(5);

        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}



        //IEnumerable<int> list = new List<int> { 2, 5, 2, 5, 3, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        //var result = list.Skip(5).Take(2);

        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);//1,2
        //}



        //IEnumerable<int> list = new List<int> { -2, 5, 2, 5, 3, 1, 2, 3, 4, 5, 6, 7, 8, -9 };

        //var result = list.SkipWhile(x => x < 0);

        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);//5, 2, 5, 3, 1, 2, 3, 4, 5, 6, 7, 8, -9
        //}



        //IEnumerable<int> list = new List<int> { -2, 5, 2, 5, 3, 1, 2, 3, 4, 5, 6, 7, 8, -9 };

        //var result = list.TakeWhile(x => x < 0);

        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}



        //IEnumerable<int> list = new List<int> { -2, 5, 2, 5, 3, 1, 2, 3, 4, 5, 6, 7, 8, -9 };

        //var result = list.TakeLast(5);

        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);//5, 2, 5, 3, 1, 2, 3, 4, 5, 6, 7, 8, -9
        //}


        //IEnumerable<int> list1 = new List<int> { 1,2,3,4,5,6,7 };
        //IEnumerable<int> list2 = new List<int> { 3,4,5,0,11,12,13};

        //var result = list1.Except(list2);
        //Console.WriteLine(result);

        //foreach (var item in result) Console.WriteLine(item);



        //IEnumerable<int> list1 = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
        //IEnumerable<int> list2 = new List<int> { 3, 4, 5, 0, 11, 12, 13 };
        //var result = list1.Intersect(list2);
        //Console.WriteLine(result);

        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}

        //IEnumerable<int> list1 = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
        //IEnumerable<int> list2 = new List<int> { 3, 4, 5, 0, 11, 12, 13 };
        //var result = list1.Union(list2);
        //Console.WriteLine(result);

        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}*/

        /*//1-usul group va join uchun
        //var result = from student in Students
        //             join course in Courses
        //             on student.CourseId equals course.Id
        //             select new
        //             {
        //                 CourseName = course.Name,
        //                 StudentFulName = student.FirstName + " " + student.LastName
        //             };
        //var newResult = result.GroupBy(x => x.CourseName);

        //foreach (var person in newResult)
        //{
        //    Console.WriteLine(person.Key);
        //    foreach (var student in person)
        //    {
        //        Console.WriteLine(student.StudentFulName);
        //    }
        //    Console.WriteLine();
        //}*/

        /*//2 - usul group va join uchun
        var result = Courses.GroupJoin(Students,
            course => course.Id,
            student => student.Id,
            (course, student) => new
            {
                CourseName = course.Name,
                Students = student
            }
         );

        foreach (var course in result)
        {
            Console.WriteLine(course.CourseName);
            foreach (var student in course.Students)
            {
                Console.WriteLine("    " + student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();
        }*/

        /*// defender exacution
        var result = (from s in Students
                      where s.Id >= 1 && s.Id <= 3
                      select s);

        Students.Add(new Student()
        {
            Id = 2,
            FirstName = "sotvoldi",
            LastName = "Vali",
            PhoneNumber = "+9989412312321",
            CourseId = 1,
        });
        foreach (var item in result)
        {
            Console.WriteLine(item.FirstName);
        }*/



        //immedate exexution
        var result = (from s in Students
                      where s.Id >= 1 && s.Id <= 3
                      select s).ToList();

        Students.Add(new Student()
        {
            Id = 2,
            FirstName = "sotvoldii",
            LastName = "Vali=",
            PhoneNumber = "+998941231232112",
            CourseId = 1,
        });
        foreach (var item in result)
        {
            Console.WriteLine(item.FirstName);
        }

    }
}
/*public class Person
{
    public string FirstName { get; set; } = String.Empty;
    public string LastName { get; set; } = String.Empty;
    public string Address { get; set; } = String.Empty;
    public int Age { get; set; }
    public string PhoneNumber { get; set; } = String.Empty;
    public string Job { get; set; } = String.Empty;  
}*/

class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; } = String.Empty;
    public string LastName { get; set; } = String.Empty;
    public string PhoneNumber { get; set; } = String.Empty;
    public int CourseId { get; set; }
}

class Course
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
}
