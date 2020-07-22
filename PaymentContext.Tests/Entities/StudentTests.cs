using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Types;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {

        private readonly Name _name;
        private readonly Email _email;
        private readonly Document _document;
        private readonly Address _address;
        private readonly Student _student;

        public StudentTests()
        {
            _name = new Name("Test", "da Silva");
            _document = new Document("11111111111", DocumentType.CPF);
            _email = new Email("test@test.com");
            _address = new Address("Rua 1", "1234", "Bairro Legal", "Gotham", "SP", "BR", "13400000");
            _student = new Student(_document, _email, _name);
            

        }

        [TestMethod]
        public void HandActiveSubscription()
        {
            var subscription = new Subscription(null);
            var payment = new PayPalPayment("123423", DateTime.Now, DateTime.Now.AddDays(5), 10, 10, _address
            , _document, "Cheio da grana Corporation LTDA.", _email);
            subscription.AddPayment(payment);
            _student.AddSubscriptions(subscription);
            _student.AddSubscriptions(subscription);
            Assert.IsTrue(_student.Invalid);
        }

        [TestMethod]
        public void HandNoActiveSubscription()
        {
            var subscription = new Subscription(null);
            _student.AddSubscriptions(subscription);
            Assert.IsTrue(_student.Invalid);
        }

        [TestMethod]
        public void AddSubscription()
        {
             var subscription = new Subscription(null);
            var payment = new PayPalPayment("123423", DateTime.Now, DateTime.Now.AddDays(5), 10, 10, _address
            , _document, "Cheio da grana Corporation LTDA.", _email);
            subscription.AddPayment(payment);
            _student.AddSubscriptions(subscription);
            Assert.IsTrue(_student.Valid);
        }
    }
}