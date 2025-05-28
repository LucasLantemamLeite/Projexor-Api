using System.Text.RegularExpressions;
using Projexor.Domain.ExceptionExtension;

namespace Projexor.Tests;

[TestClass]
[TestCategory("UserAccount")]
public class UserAccountTest
{
    [TestMethod]
    public void Name_Is_Valid()
    {
        var validName = "Luis";
        DomainException.ThrowIfError(string.IsNullOrWhiteSpace(validName), "Name não pode ser Vazio ou Nulo.");
    }

    [TestMethod]
    public void Name_Cannot_Be_Empty()
    {
        var invalidName = "";
        var ex = Assert.ThrowsException<DomainException>(() =>
        {
            DomainException.ThrowIfError(string.IsNullOrWhiteSpace(invalidName), "Name não pode ser Vazio.");
        });
        Assert.AreEqual("Name não pode ser Vazio.", ex.Message);
    }

    [TestMethod]
    public void Login_Is_Valid()
    {
        var validLogin = "Luis1234";
        DomainException.ThrowIfError(string.IsNullOrWhiteSpace(validLogin), "Login não pode ser Vazio.");
    }

    [TestMethod]
    public void Login_Cannot_Be_Empty()
    {
        var invalidLogin = "";
        var ex = Assert.ThrowsException<DomainException>(() =>
        {
            DomainException.ThrowIfError(string.IsNullOrWhiteSpace(invalidLogin), "Login não pode ser Vazio.");
        });
        Assert.AreEqual("Login não pode ser Vazio.", ex.Message);
    }

    [TestMethod]
    public void Password_Is_Valid()
    {
        var validPassword = "12345";
        DomainException.ThrowIfError(string.IsNullOrWhiteSpace(validPassword), "Password não pode ser Vazio.");
    }

    [TestMethod]
    public void Password_Cannot_Be_Empty()
    {
        var invalidPassword = "";
        var ex = Assert.ThrowsException<DomainException>(() =>
        {
            DomainException.ThrowIfError(string.IsNullOrWhiteSpace(invalidPassword), "Password não pode ser Vazio.");
        });
        Assert.AreEqual("Password não pode ser Vazio.", ex.Message);
    }

    [TestMethod]
    public void Email_Is_Valid()
    {
        var validEmail = "teste@gmail.com";
        EmailRegexException.ThrowIfNotMatch(validEmail, "Email Inválido.");
    }

    [TestMethod]
    public void Email_Cannot_Be_Empty()
    {
        var invalidEmail = "";
        var ex = Assert.ThrowsException<EmailRegexException>(() =>
        {
            EmailRegexException.ThrowIfNotMatch(invalidEmail, "Email Inválido.");
        });
        Assert.AreEqual("Email Inválido.", ex.Message);
    }

    [TestMethod]
    public void Email_Without_Domain()
    {
        var invalidEmail = "teste";
        var ex = Assert.ThrowsException<EmailRegexException>(() =>
        {
            EmailRegexException.ThrowIfNotMatch(invalidEmail, "Email Inválido.");
        });
        Assert.AreEqual("Email Inválido.", ex.Message);
    }

    [TestMethod]
    public void Email_Without_LocalPart()
    {
        var invalidEmail = "@gmail.com";
        var ex = Assert.ThrowsException<EmailRegexException>(() =>
        {
            EmailRegexException.ThrowIfNotMatch(invalidEmail, "Email Inválido.");
        });
        Assert.AreEqual("Email Inválido.", ex.Message);
    }

    [TestMethod]
    public void Email_Is_Valid_Upper()
    {
        var validEmail = "TESTE@GMAIL.COM";
        EmailRegexException.ThrowIfNotMatch(validEmail, "Email Inválido.");
    }

    [TestMethod]
    public void PhoneNumber_Is_Valid()
    {
        var validPhoneNumber = "+5541980502010";
        PhoneNumberException.ThrowIfNotMatch(validPhoneNumber, "PhoneNumber Inválido.");
    }

    [TestMethod]
    public void PhoneNumber_Without_Plus()
    {
        var invalidPhoneNumber = "5541980502010"; // Without +
        var ex = Assert.ThrowsException<PhoneNumberException>(() =>
        {
            PhoneNumberException.ThrowIfNotMatch(invalidPhoneNumber, "PhoneNumber Inválido.");
        });
        Assert.AreEqual("PhoneNumber Inválido.", ex.Message);
    }

    [TestMethod]
    public void PhoneNumber_Extra_Digits()
    {
        var invalidPhoneNumber = "+554198050201045678921"; // 21 digits
        var ex = Assert.ThrowsException<PhoneNumberException>(() =>
        {
            PhoneNumberException.ThrowIfNotMatch(invalidPhoneNumber, "PhoneNumber Inválido.");
        });
        Assert.AreEqual("PhoneNumber Inválido.", ex.Message);
    }

    [TestMethod]
    public void PhoneNumber_Invalid_Short()
    {
        var invalidPhoneNumber = "+5541980"; // 7 digits
        var ex = Assert.ThrowsException<PhoneNumberException>(() =>
        {
            PhoneNumberException.ThrowIfNotMatch(invalidPhoneNumber, "PhoneNumber Inválido.");
        });
        Assert.AreEqual("PhoneNumber Inválido.", ex.Message);
    }

    [TestMethod]
    public void PhoneNumber_Without_Extra_Pontuation()
    {
        var validPhoneNumber = "+55(41)9805-02010";
        PhoneNumberException.ThrowIfNotMatch(validPhoneNumber, "PhoneNumber Inválido.");
    }

    [TestMethod]
    public void BirthDate_Is_Valid()
    {
        var date = new DateTime(2005, 08, 04);
        BirthDateException.ThrowIfError(date, "BirthDate não pode ser uma data futura.");
    }

    [TestMethod]
    public void BirthDate_Cannot_Be_A_Future_Date()
    {
        var date = DateTime.Now.AddSeconds(1);
        var ex = Assert.ThrowsException<BirthDateException>(() =>
        {
            BirthDateException.ThrowIfError(date, "Birth Date não pode ser uma data futura.");
        });
        Assert.AreEqual("Birth Date não pode ser uma data futura.", ex.Message);
    }
}