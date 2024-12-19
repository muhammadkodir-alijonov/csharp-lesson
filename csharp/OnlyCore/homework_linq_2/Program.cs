using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<User> users = new List<User>()
        {
            new User { Id = 1,FirstName = "John", LastName = "Doe", Age = 25, Email = "john@example.com", Password = "password1" },
            new User { Id = 2,FirstName = "Jane", LastName = "Smith", Age = 30, Email = "jane@example.com", Password = "password2" },
            new User { Id = 3,FirstName = "David", LastName = "Johnson", Age = 35, Email = "david@example.com", Password = "password3" }
        };

        List<Blog> blogs = new List<Blog>()
        {
            new Blog { Id = 1, Title = "Blog 1", Definition = "Definition 1", DateTime = DateTime.Now, UserId = 1 },
            new Blog { Id = 2, Title = "Blog 2", Definition = "Definition 2", DateTime = DateTime.Now, UserId = 2 },
            new Blog { Id = 3, Title = "Blog 3", Definition = "Definition 3", DateTime = DateTime.Now, UserId = 3 }
        }; 

        var result = from blog in blogs
                     join user in users on blog.UserId equals user.Id
                     select new
                     {
                         BlogName = blog.Title,
                         BlogText = blog.Definition,
                         AuthorName = $"{user.FirstName} {user.LastName}"
                     };

        foreach (var item in result)
        {
            Console.WriteLine($"Blog Name: {item.BlogName}");
            Console.WriteLine($"Blog Text: {item.BlogText}");
            Console.WriteLine($"Author Name: {item.AuthorName}");
            Console.WriteLine();
        }
    }
}

class User
{
    public int Id { get; set; }
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
    public int UserId { get; set; }
}
