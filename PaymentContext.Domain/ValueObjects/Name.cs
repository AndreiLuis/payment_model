using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(
                new Contract()
                .Requires()
                .HasMinLen(FirstName, 3, "Name.FirstName", "Nome deve conter no minimo, 3 carateres")
                .HasMinLen(lastName, 3, "Name.LastName", "Sobre nome deve conter no minimo, 3 carateres")
                .HasMaxLen(FirstName, 20, "Name.FirstName", "Nome deve conter no máximo, 20 carateres")
                .HasMaxLen(lastName, 40, "Name.LastName", "Sobre nome deve conter no máximo, 40 carateres")
            );
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}