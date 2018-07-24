namespace StripeTests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class StripeApplicationFeeServiceTest : BaseStripeTest
    {
        private const string ApplicationFeeId = "fee_123";

        private StripeApplicationFeeService service;
        private StripeApplicationFeeListOptions listOptions;

        public StripeApplicationFeeServiceTest()
        {
            this.service = new StripeApplicationFeeService();

            this.listOptions = new StripeApplicationFeeListOptions()
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Get()
        {
            var applicationFee = this.service.Get(ApplicationFeeId);
            Assert.NotNull(applicationFee);
            Assert.Equal("application_fee", applicationFee.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var applicationFee = await this.service.GetAsync(ApplicationFeeId);
            Assert.NotNull(applicationFee);
            Assert.Equal("application_fee", applicationFee.Object);
        }

        [Fact]
        public void List()
        {
            var applicationFees = this.service.List(this.listOptions);
            Assert.NotNull(applicationFees);
            Assert.Equal("list", applicationFees.Object);
            Assert.Single(applicationFees.Data);
            Assert.Equal("application_fee", applicationFees.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var applicationFees = await this.service.ListAsync(this.listOptions);
            Assert.NotNull(applicationFees);
            Assert.Equal("list", applicationFees.Object);
            Assert.Single(applicationFees.Data);
            Assert.Equal("application_fee", applicationFees.Data[0].Object);
        }

        [Fact]
        public void Refund()
        {
            var applicationFee = this.service.Refund(ApplicationFeeId, 100);
            Assert.NotNull(applicationFee);
            Assert.Equal("application_fee", applicationFee.Object);
        }

        [Fact]
        public async Task RefundAsync()
        {
            var applicationFee = await this.service.RefundAsync(ApplicationFeeId, 100);
            Assert.NotNull(applicationFee);
            Assert.Equal("application_fee", applicationFee.Object);
        }
    }
}
