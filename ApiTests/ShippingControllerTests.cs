using Api;
using NUnit.Framework;

namespace ApiTests
{
    public class ShippingControllerTests
    {
        [Test]
        public void GetAddress_ReturnsAmazonHQAddress()
        {
            var shippingController = new ShippingController(new ShippingServiceStub());
            var result = shippingController.GetAddress();
            
            Assert.AreEqual("410 Terry Ave. North", result.StreetAddress);
            Assert.AreEqual("Seattle", result.City);
        }
    }

    public class ShippingServiceStub : IShippingService
    {
        public Address GetDefaultAddress()
        {
            return new("410 Terry Ave. North", "Seattle");
        }
    }
}