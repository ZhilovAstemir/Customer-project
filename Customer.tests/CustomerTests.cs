using System;
using Xunit;

namespace Customer.tests
{
    public class CustomerTests
    {
        [Fact]
        public void ShouldBeAbleToCreateCustomer()
        {
            Customer customer = new Customer();
        }

        [Fact]
        public void ShouldNotBeAbleToSetFirstNamePersone()
        {
            Customer customer = new Customer();
            Assert.Throws<InvalidOperationException>(() => customer.SetFirstName("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"));
        }

        [Fact]
        public void ShouldNotBeAbleToSetLastNamePersone()
        {
            Customer customer = new Customer();
            Assert.Throws<InvalidOperationException>(() => customer.SetLastName("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"));
            Assert.Throws<InvalidOperationException>(() => customer.SetLastName(""));
        }

        [Fact]
        public void ShouldBeAbleToSetFirstNamePersone()
        {
            Customer customer = new Customer();
            customer.SetFirstName("Ivan");
            Assert.Equal("Ivan", customer.FirstName);
            customer.SetFirstName("");
            Assert.Equal("", customer.FirstName);
        }

        [Fact]
        public void ShouldBeAbleToSetLastNamePersone()
        {
            Persone customer = new Customer();
            customer.SetLastName("Demin");
            Assert.Equal("Demin", customer.LastName); ;
        }

        [Fact]
        public void ShouldBeAbleToGetAddres()
        {
            Customer customer = new Customer();
            Assert.True(customer.addres.Count > 0);
        }

        [Fact]
        public void ShouldBeAbleToSetEmail()
        {
            Customer customer = new Customer();
            customer.SetEmail("ivan@gmail.com");
            Assert.Equal("ivan@gmail.com", customer.Email);
        }

        [Fact]
        public void ShouldNotBeAbleToSetEmail()
        {
            Customer customer = new Customer();           
            Assert.Throws<InvalidOperationException>(() => customer.SetEmail("12@.com"));
        }

        [Fact]
        public void ShouldBeAbleToSetPhoneNumber()
        {
            Customer customer = new Customer();
            customer.SetPhoneNumber("12345678945");
            Assert.Equal("12345678945", customer.PhoneNumber);
        }

        [Fact]
        public void ShouldNotBeAbleToSetPhoneNumber()
        {
            Customer customer = new Customer();
            Assert.Throws<InvalidOperationException>(() => customer.SetPhoneNumber("12@.com"));
        }

        [Fact]
        public void ShouldBeAbleToGetNotes()
        {
            Customer customer = new Customer();
            Assert.True(customer.notes.Count > 0);
        }

        [Fact]
        public void ShouldBeAbleToSetTotalPurchasesAmount()
        {
            Customer customer = new Customer();
            customer.SetTotalPurchasesAmount(1234);
            Assert.Equal(1234, customer.TotalPurchasesAmount);
            customer.SetTotalPurchasesAmount(null);
            Assert.Equal(null, customer.TotalPurchasesAmount);
        }
    }
}