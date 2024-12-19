using System;
using System.Collections.Generic;
using System.Linq;

public class User
{
    public int UserId { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}

public class Blog
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Definition { get; set; } = string.Empty;
    public DateTime DateTime { get; set; }
    public int UserId { get; set; }
}

public class Comment
{
    public int Id { get; set; }
    public string Text { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public int BlogId { get; set; }
}

public static class MockData
{
    public static List<User> Users { get; } = new List<User>()
    {
        new User { UserId = 1,FirstName = "John", LastName = "Doe", Age = 25, Email = "john@example.com", Password = "password1" },
        new User { UserId = 2, FirstName = "Bob", LastName = "Johnson", Age = 28, Email = "bob@example.com", Password = "password3" },
        new User { UserId = 3, FirstName = "Alice", LastName = "Smith", Age = 30, Email = "alice@example.com", Password = "password2" },
        new User { UserId = 4, FirstName = "Emma", LastName = "Davis", Age = 22, Email = "emma@example.com", Password = "password4" },
        new User { UserId = 5, FirstName = "Michael", LastName = "Brown", Age = 35, Email = "michael@example.com", Password = "password5" }
    };

    public static List<Blog> Blogs { get; } = new List<Blog>()
    {
        new Blog { Id = 1, Title = "First Blog", Definition = "This is the first blog", DateTime = DateTime.Now, UserId = 1 },
        new Blog { Id = 2, Title = "Second Blog", Definition = "This is the second blog", DateTime = DateTime.Now, UserId = 3 },
        new Blog { Id = 3, Title = "Third Blog", Definition = "This is the third blog", DateTime = DateTime.Now, UserId = 2 },
        new Blog { Id = 4, Title = "Fourth Blog", Definition = "This is the fourth blog", DateTime = DateTime.Now, UserId = 4 },
        new Blog { Id = 5, Title = "Fifth Blog", Definition = "This is the fifth blog", DateTime = DateTime.Now, UserId = 5 }
    };

    public static List<Comment> Comments { get; } = new List<Comment>()
    {
        new Comment { Id = 1, Text = "First comment", CreatedAt = DateTime.Now, BlogId = 1 },
        new Comment { Id = 2, Text = "Second comment", CreatedAt = DateTime.Now, BlogId = 2 },
        new Comment { Id = 3, Text = "Third comment", CreatedAt = DateTime.Now, BlogId = 1 },
        new Comment { Id = 4, Text = "Fourth comment", CreatedAt = DateTime.Now, BlogId = 3 },
        new Comment { Id = 5, Text = "Fifth comment", CreatedAt = DateTime.Now, BlogId = 4 },
        new Comment { Id = 6, Text = "Sixth comment", CreatedAt = DateTime.Now, BlogId = 1 },
        new Comment { Id = 7, Text = "Seventh comment", CreatedAt = DateTime.Now, BlogId = 5 },
        new Comment { Id = 8, Text = "Eighth comment", CreatedAt = DateTime.Now, BlogId = 2 },
        new Comment { Id = 9, Text = "Ninth comment", CreatedAt = DateTime.Now, BlogId = 3 },
        new Comment { Id = 10, Text = "Tenth comment", CreatedAt = DateTime.Now, BlogId = 4 }
    };
}

public class BlogViewModel
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Definition { get; set; } = string.Empty;
    public DateTime DateTime { get; set; }
    public string AuthorName { get; set; } = string.Empty;
    public IEnumerable<Comment> Comments { get; set; } = new List<Comment>();
}

public static class Program
{
    public static void Main()
    {
        List<BlogViewModel> blogViewModels = GetBlogViewModelsWithJoin();//GetBlogViewModels();

        foreach (var blogViewModel in blogViewModels)
        {
            Console.WriteLine($"Blog Id: {blogViewModel.Id}");
            Console.WriteLine($"Title: {blogViewModel.Title}");
            Console.WriteLine($"Definition: {blogViewModel.Definition}");
            Console.WriteLine($"DateTime: {blogViewModel.DateTime}");
            Console.WriteLine($"Author Name: {blogViewModel.AuthorName}");
            Console.WriteLine("Comments:");
            foreach (var comment in blogViewModel.Comments)
            {
                Console.WriteLine($"- {comment.Text} ({comment.CreatedAt})");
            }
            Console.WriteLine();
        }
    }

    public static List<BlogViewModel> GetBlogViewModels()
    {
        var blogViewModels = MockData.Blogs.Select(blog => new BlogViewModel
        {
            Id = blog.Id,
            Title = blog.Title,
            Definition = blog.Definition,
            DateTime = blog.DateTime,
            AuthorName = $"{MockData.Users.First(user => user.UserId == blog.UserId).FirstName} {MockData.Users.First(user => user.UserId == blog.UserId).LastName}",
            Comments = MockData.Comments.Where(comment => comment.BlogId == blog.Id)
        }).ToList();

        return blogViewModels;
    }
    public static List<BlogViewModel> GetBlogViewModelsWithJoin()
    {
        var blogViewModels = MockData.Blogs.Join(
            MockData.Users,
            blog => blog.UserId,
            user => user.UserId,
            (blog, user) => new BlogViewModel
            {
                Id = blog.Id,
                Title = blog.Title,
                Definition = blog.Definition,
                DateTime = blog.DateTime,
                AuthorName = $"{user.FirstName} {user.LastName}",
                Comments = MockData.Comments.Where(comment => comment.BlogId == blog.Id)
            }).ToList();

        return blogViewModels;
    }

}
