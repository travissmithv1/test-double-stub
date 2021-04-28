namespace Api
{
    public interface IShippingService
    {
        Address GetDefaultAddress();
    }

    public class ShippingService : IShippingService
    {
        public Address GetDefaultAddress()
        {
            return new("Simulating", "Not Used");
        }
    }
}