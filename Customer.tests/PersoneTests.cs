using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Customer.tests
{   
    public class PersoneTests
    {
        [Fact]
        public void ShouldBeAbleToCreatePersone()
        {
            Persone persone = new Customer();
        }

        [Fact]
        public void ShouldNotBeAbleToSetFirstNamePersone()
        {
            Persone persone = new Customer();
            Assert.Throws<InvalidOperationException>(() => persone.SetFirstName("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"));
        }

        [Fact]
        public void ShouldNotBeAbleToSetLastNamePersone()
        {
            Persone persone = new Customer();
            Assert.Throws<InvalidOperationException>(() => persone.SetLastName("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"));
            Assert.Throws<InvalidOperationException>(() => persone.SetLastName(""));
        }

        [Fact]
        public void ShouldBeAbleToSetFirstNamePersone()
        {
            Persone persone = new Customer();
            persone.SetFirstName("Ivan");
            Assert.Equal("Ivan", persone.FirstName);
            persone.SetFirstName("");
            Assert.Equal("", persone.FirstName);
        }

        [Fact]
        public void ShouldBeAbleToSetLastNamePersone()
        {
            Persone persone = new Customer();
            persone.SetLastName("Demin");
            Assert.Equal("Demin", persone.LastName);;
        }
    }
}
