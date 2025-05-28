using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projexor.Domain.Entity;

namespace Projexor.Data.Mapping;

public class UserAccountMap : IEntityTypeConfiguration<UserAccount>
{
    public void Configure(EntityTypeBuilder<UserAccount> builder)
    {
        builder.ToTable("UserAccount");

        builder.Property(x => x.Id)
        .HasColumnName("Id")
        .HasColumnType("Int")
        .ValueGeneratedOnAdd()
        .UseIdentityColumn();

        builder.OwnsOne(x => x.Name, a =>
        {
            a.Property(x => x.Value)
            .HasColumnName("Name")
            .HasColumnType("Nvarchar(100)")
            .IsRequired();
        });

        builder.OwnsOne(x => x.Login, a =>
        {
            a.Property(x => x.Value)
            .HasColumnName("Login")
            .HasColumnType("Nvarchar(30)")
            .IsRequired();

            a.HasIndex(x => x.Value, "Unique_Key_Login_UserAccount")
            .IsUnique();
        });

        builder.OwnsOne(x => x.PasswordHash, a =>
        {
            a.Property(x => x.Value)
            .HasColumnName("PasswordHash")
            .HasColumnType("NVarchar(64)")
            .IsRequired();
        });

        builder.OwnsOne(x => x.Email, a =>
        {
            a.Property(x => x.Value)
            .HasColumnName("Email")
            .HasColumnType("Nvarchar(254)")
            .IsRequired();

            a.HasIndex(x => x.Value, "Unique_Key_Email_UserAccount")
            .IsUnique();
        });

        builder.OwnsOne(x => x.PhoneNumber, a =>
        {
            a.Property(x => x.Value)
            .HasColumnName("PhoneNumber")
            .HasColumnType("Nvarchar(20)")
            .IsRequired();

            a.HasIndex(x => x.Value, "Unique_Key_PhoneNumber_UserAccount")
            .IsUnique();
        });

        builder.OwnsOne(x => x.BirthDate, a =>
        {
            a.Property(x => x.Value)
            .HasColumnName("BirthDate")
            .HasColumnType("SmallDateTime")
            .IsRequired();
        });

        builder.OwnsOne(x => x.Active, a =>
        {
            a.Property(x => x.Value)
            .HasColumnName("Active")
            .HasColumnType("Bit")
            .IsRequired();
        });

        builder.Property(x => x.CreatAt)
        .HasColumnName("CreatAt")
        .HasColumnType("SmallDateTime")
        .IsRequired();

    }
}