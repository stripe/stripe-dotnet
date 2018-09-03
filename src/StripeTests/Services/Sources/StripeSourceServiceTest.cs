namespace StripeTests
{
    using System;
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
                Mandate = new StripeSourceMandateOptions
                {
                    MandateAcceptanceDate = DateTime.Parse("Mon, 01 Jan 2001 00:00:00Z"),
                    MandateAcceptanceIp = "127.0.0.1",
                    MandateAcceptanceStatus = "accepted",
                    MandateAcceptanceUserAgent = "User-Agent",
                    MandateNotificationMethod = "manual",
                },
                Receiver = new StripeSourceReceiverOptions
                {
                    RefundAttributesMethod = "manual",
                },
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
