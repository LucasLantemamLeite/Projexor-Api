using Projexor.Domain.ValueObjects;

namespace Projexor.Domain.Entity;

public class UserAccount : Entity
{
    public int Id { get; private set; }
    public Name Name { get; private set; }
    public Login Login { get; private set; }
    public Password PasswordHash { get; private set; }
    public Email Email { get; private set; }
    public PhoneNumber PhoneNumber { get; private set; }
    public BirthDate BirthDate { get; private set; }
    public DateTime CreatAt { get; private set; } = DateTime.UtcNow;
    public Active Active { get; private set; }

    public UserAccount() { }

    public UserAccount(string name, string login, string password, string email, string phone_number, DateTime date)
    {
        Name = new Name(name);
        Login = new Login(login);
        PasswordHash = new Password(password);
        Email = new Email(email);
        PhoneNumber = new PhoneNumber(phone_number);
        BirthDate = new BirthDate(date);
        Active = new Active();
    }
}