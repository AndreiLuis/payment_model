using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(
            string barcode, 
            string numberBoleto,
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
            Barcode = barcode;
            NumberBoleto = numberBoleto;
        }

        public string Barcode { get; private set; }
        public string NumberBoleto { get; private set; }
    }

}