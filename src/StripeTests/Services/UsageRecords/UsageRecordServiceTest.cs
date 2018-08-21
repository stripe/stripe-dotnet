namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class UsageRecordServiceTest : BaseStripeTest
    {
        private UsageRecordService service;
        private UsageRecordCreateOptions createOptions;

        public UsageRecordServiceTest()
        {
            this.service = new UsageRecordService();

            this.createOptions = new UsageRecordCreateOptions()
            {
                Quantity = 10,
                SubscriptionItem = "si_123",
                Timestamp = DateTime.Now,
            };
        }

        [Fact]
        public void Create()
        {
            var plan = this.service.Create(this.createOptions);
            Assert.NotNull(plan);
            Assert.Equal("usage_record", plan.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var plan = await this.service.CreateAsync(this.createOptions);
            Assert.NotNull(plan);
            Assert.Equal("usage_record", plan.Object);
        }
    }
}
