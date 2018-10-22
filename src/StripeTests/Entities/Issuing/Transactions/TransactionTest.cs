namespace StripeTests.Issuing
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Issuing;
    using Xunit;

    public class TransactionTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/issuing/transactions/ipi_123");
            var transaction = Mapper<Transaction>.MapFromJson(json);
            Assert.NotNull(transaction);
            Assert.IsType<Transaction>(transaction);
            Assert.NotNull(transaction.Id);
            Assert.Equal("issuing.transaction", transaction.Object);
        }
    }
}
