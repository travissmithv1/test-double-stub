namespace Api
{
    public class ShippingController
    {
        private readonly IShippingService _shippingService;

        public ShippingController() : this(new ShippingService())
        {
        }

        public ShippingController(IShippingService shippingService)
        {
            _shippingService = shippingService;
        }
        
        public Address GetAddress()
        {
            return _shippingService.GetDefaultAddress();
        }
    }
}