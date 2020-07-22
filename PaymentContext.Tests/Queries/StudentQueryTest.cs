using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Queries;
using PaymentContext.Domain.Types;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.Queries
{
    [TestClass]
    public class StudentQueryTest
    {
        public IList<Student> _students;

        public StudentQueryTest(){
            for(var i = 0; i <= 10; i ++){
                _students.Add(new Student(
                    new Document("1111111111" + i.ToString(), DocumentType.CPF),
                    new Email(i.ToString() + "@balta.io"),
                    new Name("Aluno", i.ToString())
                ));
            }
        }

        [TestMethod]
        public void NullWhenDocumentNotExists()
        {
            var exp = StudentQuery.GetStudentInfo("123456789");
            var studn = _students.AsQueryable().Where(exp).FirstOrDefault();

            Assert.AreNotEqual(null, studn);
        }

        
        [TestMethod]
        public void StudentWhenDocumentExists()
        {
            var exp = StudentQuery.GetStudentInfo("1111111111");
            var studn = _students.AsQueryable().Where(exp).FirstOrDefault();

            Assert.AreNotEqual(null, studn);
        }
    }
}