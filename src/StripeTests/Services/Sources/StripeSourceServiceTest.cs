namespace StripeTests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class StripeSourceServiceTest : BaseStripeTest
    {
        private const string SourceId = "src_123";

        private StripeSourceService service;
        private StripeSourceCreateOptions createOptions;
        private StripeSourceUpdateOptions updateOptions;
        private StripeSourceListOptions listOptions;

        public StripeSourceServiceTest()
        {
            this.service = new StripeSourceService();

            this.createOptions = new StripeSourceCreateOptions
            {
                Type = StripeSourceType.AchCreditTransfer,
                Currency = "usd",
                Owner = new StripeSourceOwnerOptions
                {
                    Email = "amount_1001@example.com",
                    CityOrTown = "Mayberry",
                    State = "NC"
                }
            };

            this.updateOptions = new StripeSourceUpdateOptions
            {
                Metadata = new Dictionary<string, string>()
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new StripeSourceListOptions()
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var source = this.service.Create(this.createOptions);
            Assert.NotNull(source);
            Assert.Equal("source", source.Object);
        }
    }
}
