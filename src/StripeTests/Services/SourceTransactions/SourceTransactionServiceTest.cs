namespace StripeTests
{
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class SourceTransactionServiceTest : BaseStripeTest
    {
        private const string SourceId = "src_123";

        private readonly SourceTransactionService service;
        private readonly SourceTransactionsListOptions listOptions;

        public SourceTransactionServiceTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
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
            var sourceTransactions = this.service.List(SourceId, this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/sources/src_123/source_transactions");
            Assert.NotNull(sourceTransactions);
            Assert.Equal("list", sourceTransactions.Object);
            Assert.Single(sourceTransactions.Data);
            Assert.Equal("source_transaction", sourceTransactions.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var sourceTransactions = await this.service.ListAsync(SourceId, this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/sources/src_123/source_transactions");
            Assert.NotNull(sourceTransactions);
            Assert.Equal("list", sourceTransactions.Object);
            Assert.Single(sourceTransactions.Data);
            Assert.Equal("source_transaction", sourceTransactions.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var sourceTransactions = this.service.ListAutoPaging(SourceId, this.listOptions).ToList();
            Assert.NotNull(sourceTransactions);
            Assert.Equal("source_transaction", sourceTransactions[0].Object);
        }
    }
}
