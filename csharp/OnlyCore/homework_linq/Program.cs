namespace homework_linq_1;

public class Program
{
    private static IList<User> Users = new List<User>()
    {
        new User
        {
            Id = 1,
            FirstName = "Qahhor",
            LastName = "Xurramov",
            Age = 21,
            Email = "Qahhor2002@gmail.com",
            Password = "Qahhor21"
        },
        new User
        {
            Id=2,
            FirstName = "Muhammad",
            LastName = "Alijonov",
            Age = 20,
            Email = "Muhammad2002@gmail.com",
            Password = "Muhammad20"
        },
        new User
        {
            Id =3,
            FirstName = "Asror",
            LastName = "Abdullayev",
            Age = 23,
            Email = "Asror2001@gmail.com",
            Password = "Asror23"
        },
        new User
        {
            Id =3,
            FirstName = "Xavasbek",
            LastName = "Alijonov",
            Age = 19,
            Email = "Xavasbek2003@gmail.com",
            Password = "Xavasbek19"
        },
        new User
        {
            Id =2,
            FirstName = "Avaz",
            LastName = "Alijonov",
            Age = 15,
            Email = "Avaz2003@gmail.com",
            Password = "Xavasbek19"
        },
    };
    private static IList<Blog> Blogs = new List<Blog>()
    {
        new Blog
        {
            Id = 1,
            Title = "Instagram",
            Definition = "Reels, stroty, post",
            DateTime = DateTime.Now
        },
        new Blog
        {
            Id = 2,
            Title = "Telegram",
            Definition = "channel, post",
            DateTime = DateTime.Now
        },
        new Blog
        {
            Id = 3,
            Title = "Facebook",
            Definition = "Reels, stroty, post, commet",
            DateTime = DateTime.Now
        },

    };
    static void Main(string[] args)
    {
        /*var result = from users in Users
                     join blogs in Blogs
                     on users.Id equals blogs.Id
                     select new
                     {
                         UserName = users.LastName,
                         BlogName = blogs.Title + "  " + blogs.Definition
                     };
        var fullyresult = result.GroupBy(x => x.UserName);
        foreach (var users in fullyresult)
        {
            Console.WriteLine(users.Key);
            foreach (var blogs in users)
            {
                Console.WriteLine(blogs.BlogName);
            }
            Console.WriteLine("");
        }*/

        var result = Users.GroupJoin(Blogs,
            users => users.Id,
            blogs => blogs.Id,
            (users, blogs) => new
            {
                UserName = users.FirstName + "  " + users.LastName,
                BlogName = blogs
            }
            );
        foreach (var users in result)
        {
            Console.WriteLine(users.UserName);
            foreach (var blogs in users.BlogName)
            {
                Console.WriteLine(blogs.Title + " " + blogs.Definition);
            }
            Console.WriteLine("");
        }
    }
}
class User
{
    public  int  Id { get; set; }
    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public int Age { get; set; }

    public string Email { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;
}

class Blog
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Definition { get; set; } = string.Empty;

    public DateTime DateTime { get; set; }
}