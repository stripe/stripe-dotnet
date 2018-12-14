namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class SourceTransactionServiceTest : BaseStripeTest
    {
        private const string SourceId = "src_123";

        private readonly SourceTransactionService service;
        private readonly SourceTransactionsListOptions listOptions;

        public SourceTransactionServiceTest()
        {
            this.service = new SourceTransactionService();

            this.listOptions = new SourceTransactionsListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void List()
        {
            var sources = this.service.List(SourceId, this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/sources/src_123/source_transactions");
            Assert.NotNull(sources);
            Assert.Equal("list", sources.Object);
            Assert.Single(sources.Data);
            Assert.Equal("source_transaction", sources.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var sources = await this.service.ListAsync(SourceId, this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/sources/src_123/source_transactions");
            Assert.NotNull(sources);
            Assert.Equal("list", sources.Object);
            Assert.Single(sources.Data);
            Assert.Equal("source_transaction", sources.Data[0].Object);
        }
    }
}
