using System;

namespace Customer
{
    public class Addres
    {
        public string? City;
        public string? PostalCode;
        public string? State;
        public string? Country;

        public void SetCity(string city)
        {
            if((city.Length > 50) || (city.Length < 1))
            {
                throw new InvalidOperationException("Can't set Addres City greater than 50 chars and less than 1 chars");
            }
            City = city;
        }

        public void SetPostalCode(string postalCode)
        {
            if ((postalCode.Length > 6) || (postalCode.Length < 1))
            {
                throw new InvalidOperationException("Can't set Addres Postal Code greater than 6 chars and less than 1 chars");
            }
            PostalCode = postalCode;
        }

        public void SetState(string state)
        {
            if ((state.Length > 20) || (state.Length < 1))
            {
                throw new InvalidOperationException("Can't set Addres State greater than 20 chars and less than 1 chars");
            }
            State = state;
        }

        public void SetCountry(string country)
        {
            if ((country == "Canada") || (country == "United States"))
            {
                Country = country;
            }
            else
            throw new InvalidOperationException("Can't set Addres Country greater than 20 chars and less than 1 chars");
        }
    }
}
