using System;
using Xunit;

namespace Customer.tests
{
    public class AddresTests
    {
        [Fact]
        public void ShouldBeAbleToCreateAddres()
        {
            Addres addres = new Addres();
        }

        [Fact]
        public void ShouldBeAbleToSetCity()
        {
            Addres addres = new Addres();
            addres.SetCity("Georgy");
            Assert.Equal("Georgy", addres.City);
        }

        [Fact]
        public void ShouldNotBeAbleToSetCity()
        {
            Addres addres = new Addres();
            Assert.Throws<InvalidOperationException>(() => { addres.SetCity("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"); });
            Assert.Throws<InvalidOperationException>(() => { addres.SetCity(""); });
        }

        [Fact]
        public void ShouldBeAbleToSetPostalCode()
        {
            Addres addres = new Addres();
            addres.SetPostalCode("123456");
            Assert.Equal("123456", addres.PostalCode);
        }

        [Fact]
        public void ShouldNotBeAbleToSetPostalCode()
        {
            Addres addres = new Addres();
            Assert.Throws<InvalidOperationException>(() => { addres.SetPostalCode("1234567"); });
            Assert.Throws<InvalidOperationException>(() => { addres.SetPostalCode(""); });
        }

        [Fact]
        public void ShouldBeAbleToSetState()
        {
            Addres addres = new Addres();
            addres.SetState("Georgy");
            Assert.Equal("Georgy", addres.State);
        }

        [Fact]
        public void ShouldNotBeAbleToSetState()
        {
            Addres addres = new Addres();
            Assert.Throws<InvalidOperationException>(() => { addres.SetState("aaaaaaaaaaaaaaaaaaaaa"); });
            Assert.Throws<InvalidOperationException>(() => { addres.SetState(""); });
        }

        [Fact]
        public void ShouldBeAbleToSetCountry()
        {
            Addres addres = new Addres();
            addres.SetCountry("Canada");
            Assert.Equal("Canada", addres.Country);
            addres.SetCountry("United States");
            Assert.Equal("United States", addres.Country);
        }

        [Fact]
        public void ShouldNotBeAbleToSetCountry()
        {
            Addres addres = new Addres();
            Assert.Throws<InvalidOperationException>(() => { addres.SetCountry("Russia"); });
            Assert.Throws<InvalidOperationException>(() => { addres.SetCountry(""); });
        }
    }
}
