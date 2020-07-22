using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Repositories;

namespace PaymentContext.Tests.Mocks
{
    public class FakeStudentRepository : IStudentRepository
    {
        public void CreateSubscription(Student student)
        {

        }

        public bool DocumentExists(string document)
        {
            if (document == "99999999999")
                return false;
            return true;
        }

        public bool EmailExists(string email)
        {
            if (email == "batata@pure.com")
                return true;
            return false;
        }
    }
}