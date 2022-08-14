using System.Text.RegularExpressions;

namespace Customer
{
    public class Customer : Persone
    {
        public List<Addres> addres = new List<Addres>() { new Addres { City = "Georgy", Country = "United States", PostalCode = "123456", State = "Georgy" } };
        public List<string> notes = new List<string>() { "Idk" };
        public string? Email;
        public string? PhoneNumber;
        public decimal? TotalPurchasesAmount;
        Regex patternEmail = new(@"^((\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)\s*[;]{0,1}\s*)+$");
        Regex patternPhone = new(@"\d{11}");

        public void SetEmail(string email)
        {
            if (!patternEmail.IsMatch(email))
            {
                throw new InvalidOperationException(email + "is not an email");
            }
            Email = email;
        }

        public void SetPhoneNumber(string phoneNumber)
        {
            if (!patternPhone.IsMatch(phoneNumber))
            {
                throw new InvalidOperationException(phoneNumber + "is not an Phone Number");
            }
            PhoneNumber = phoneNumber;
        }

        public void SetTotalPurchasesAmount(decimal? totalPurchasesAmount)
        {
            TotalPurchasesAmount = totalPurchasesAmount;
        }
    }
}