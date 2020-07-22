using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Types;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class DocumentTest
    {
        [TestMethod]
        public void CNPJIsInvalid()
        {
            var document = new Document("123", DocumentType.CNPJ);
            Assert.IsTrue(document.Invalid);
        }

        [TestMethod]
        public void CNPJIsValid()
        {
            var document = new Document("11111111111111", DocumentType.CNPJ);
            Assert.IsTrue(document.Valid);
        }

        [TestMethod]
         public void CPFIsInvalid()
        {
            var document = new Document("123", DocumentType.CPF);
            Assert.IsTrue(document.Invalid);
        }

        [TestMethod]
        public void CPFIsValid()
        {
            var document = new Document("11111111111", DocumentType.CPF);
            Assert.IsTrue(document.Valid);
        }
    }
}