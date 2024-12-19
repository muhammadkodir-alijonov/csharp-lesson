namespace essential
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*int a = 1;
            int b = 2;
            Console.WriteLine(GetX(a, b));
            GetClasses();
            GC.Collect();
            Console.ReadKey();*/
            /*// redkey
            string res = "salom";
            Console.WriteLine(res);
            for (int i = 0; i < res.Length; i++)
            {
                kk:
                    var key = Console.ReadKey();
                    if (key.KeyChar != res[i])
                {
                    Console.Clear();
                    Console.WriteLine(res);
                    Console.WriteLine(res.Substring(0,i));
                    goto kk;
                }
            }*/


            Ofitsant.Shout();
        }

        /* //destructure ga main ichida ma'lumot qo'shish
         public static void GetClasses()
         {
             Person[] people = new Person[5];

             people[0] = new Person()
             {
                 id = 1,
                 name = "Test",
                 age = 30
             };
         }*/
    }
    public class Person
    {
        public void Shout()
        {
            if (OperatingSystem.IsWindows())
                Console.Beep(1000, 2000);
            Console.WriteLine("Person");
        }

    }
    public class Ofitsant
    {
        public static void Shout()
        {
            if (OperatingSystem.IsWindows())
                Console.Beep(1000, 900);
            Console.WriteLine("Ofitsant");
        }
    }
    /* // destructor
    public class Person
    {
        public int id;
        public string name;
        public int age;

        public Person()
        {
            Console.WriteLine("Constructed => 1");
        }
        public Person(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            Console.WriteLine("Constructed => 2");
        }

        ~ Person()
        {
            Console.WriteLine("Destructed ");
        }

    }*/
}