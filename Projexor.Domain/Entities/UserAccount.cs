using Projexor.Domain.ValueObjects;

namespace Projexor.Domain.Entity;

public class UserAccount : Entity
{
    public int Id { get; private set; }
    public Name Name { get; private set; }
    public Login Login { get; private set; }
    public Password PasswordHash { get; private set; }
    public Email Email { get; private set; }

    public UserAccount(string name, string login, string password, string email)
    {
        Name = new Name(name);
        Login = new Login(login);
        PasswordHash = new Password(password);
        Email = new Email(email);
    }
}