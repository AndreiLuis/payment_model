using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
      public class CreditCardPayment : Payment
    {
        public CreditCardPayment(
            string cardHolderNumber, 
            string cardNumber, 
            string lastTransactionNumber,
            DateTime paidDate, 
            DateTime expiredDate, 
            decimal total, 
            decimal totalPaid, 
            Address address, 
            Document document, 
            string payer, 
            Email email): 
        base(paidDate, expiredDate, total, totalPaid, address, document, payer, email)
        {
            CardHolderNumber = cardHolderNumber;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHolderNumber { get; private set; }
        public string CardNumber { get; private set; }
        public string LastTransactionNumber { get; private set; }
    }

}