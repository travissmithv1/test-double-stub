namespace Api
{
    public class Address
    {
        public Address(string streetAddress, string city)
        {
            StreetAddress = streetAddress;
            City = city;
        }
        
        public string StreetAddress { get; }
        public string City { get; }
    }
}