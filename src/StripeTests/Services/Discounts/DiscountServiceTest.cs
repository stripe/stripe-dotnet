namespace StripeTests
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class DiscountServiceTest : BaseStripeTest
    {
        private readonly DiscountService service;

        public DiscountServiceTest()
        {
            this.service = new DiscountService();
        }

        [Fact]
        public void DeleteCustomerDiscount()
        {
            var deleted = this.service.DeleteCustomerDiscount("cus_123");
            this.AssertRequest(HttpMethod.Delete, "/v1/customers/cus_123/discount");
            Assert.NotNull(deleted);
        }

        [Fact]
        public async Task DeleteCustomerDiscountAsync()
        {
            var deleted = await this.service.DeleteCustomerDiscountAsync("cus_123");
            this.AssertRequest(HttpMethod.Delete, "/v1/customers/cus_123/discount");
            Assert.NotNull(deleted);
        }

        [Fact]
        public void DeleteSubscriptionDiscount()
        {
            var deleted = this.service.DeleteSubscriptionDiscount("sub_123");
            this.AssertRequest(HttpMethod.Delete, "/v1/subscriptions/sub_123/discount");
            Assert.NotNull(deleted);
        }

        [Fact]
        public async Task DeleteSubscriptionDiscountAsync()
        {
            var deleted = await this.service.DeleteSubscriptionDiscountAsync("sub_123");
            this.AssertRequest(HttpMethod.Delete, "/v1/subscriptions/sub_123/discount");
            Assert.NotNull(deleted);
        }
    }
}
