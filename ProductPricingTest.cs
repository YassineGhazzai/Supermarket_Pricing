using Xunit;

namespace Supermarket_Pricing
{
    public class ProductPricingTest
    {
        private ProductPricing productPricing;

        public ProductPricingTest()
        {
            productPricing = new ProductPricing();
        }

        [Fact]
        public void No_Product_returnsZero()
        {
            Assert.Equal(0, productPricing.Pricing(""));
        }

    }
}

