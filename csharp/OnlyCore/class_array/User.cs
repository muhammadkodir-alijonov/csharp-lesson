namespace class_array
{
    internal class User
    {
        public string Firstname;
        public string Lastname;
        public string Email;
        public string Login;
        public int Age;

        public User(string firstname, string lastname, int age, string email, string login)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Age = age;
            this.Email = email;
            this.Login = login;
        }

        public User(string firstname, string lastname, int age)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Age = age;
        }

        public User(string email, string login)
        {
            this.Email = email;
            this.Login = login;
        }
    }
}
