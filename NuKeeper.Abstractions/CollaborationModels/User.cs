namespace NuKeeper.Abstractions.CollaborationModels
{
    public class User
    {
        public static readonly User Default = new User("user@email.com", "", "");

        public User(string login, string name, string email)
        {
            Login = login;
            Name = name;
            Email = email;
        }

        public User(int id, string login, string name, string email) : this(login, name, email)
        {
            Id = id;
        }

        public int? Id { get; }
        public string Login { get; }
        public string Name { get; }
        public string Email { get; }
    }
}
