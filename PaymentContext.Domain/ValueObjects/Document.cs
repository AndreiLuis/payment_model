using Flunt.Validations;
using PaymentContext.Domain.Types;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Document : ValueObject
    {
        public Document(string number, DocumentType type)
        {
            Number = number;
            Type = type;

            AddNotifications(new Contract()
                .Requires()
                .IsTrue(Validate(), "Document.Number", "Documento inválido")
            );
        }

        public string Number { get; set; }
        public DocumentType Type { get; private set; }

        private bool Validate()
        {
            if (Type == DocumentType.CNPJ && Number.Length == 14)
                return true;

            if (Type == DocumentType.CPF && Number.Length == 11)
                return true;

            return false;
        }
    }
}