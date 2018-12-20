namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class UsageRecordServiceTest : BaseStripeTest
    {
        private readonly UsageRecordService service;
        private readonly UsageRecordCreateOptions createOptions;

        public UsageRecordServiceTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
            this.service = new UsageRecordService();

            this.createOptions = new UsageRecordCreateOptions
            {
                Quantity = 10,
                Timestamp = DateTime.Now,
            };
        }

        [Fact]
        public void Create()
        {
            var plan = this.service.Create("si_123", this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/subscription_items/si_123/usage_records");
            Assert.NotNull(plan);
            Assert.Equal("usage_record", plan.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var plan = await this.service.CreateAsync("si_123", this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/subscription_items/si_123/usage_records");
            Assert.NotNull(plan);
            Assert.Equal("usage_record", plan.Object);
        }
    }
}
