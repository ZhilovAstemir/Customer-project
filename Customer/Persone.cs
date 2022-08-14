using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    public abstract class Persone
    {
        public string? FirstName;
        public string? LastName;

        public virtual void SetFirstName(string firstName)
        {
            if (firstName.Length > 50)
            {
                throw new InvalidOperationException("Can't set Persone First Name greater than 50 chars");
            }
            FirstName = firstName;
        }

        public virtual void SetLastName(string lastName)
        {
            if ((lastName.Length > 50) || (lastName.Length <= 1))
            {
                throw new InvalidOperationException("Can't set Persone Last Name greater than 50 chars and less than 1 chars");
            }
            LastName = lastName;
        }
    }
}
