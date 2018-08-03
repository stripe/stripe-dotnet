namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class StripeBankAccountTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/accounts/acct_123/external_accounts/ba_123");
            var bankAccount = Mapper<StripeBankAccount>.MapFromJson(json);
            Assert.NotNull(bankAccount);
            Assert.IsType<StripeBankAccount>(bankAccount);
            Assert.NotNull(bankAccount.Id);
            Assert.Equal("bank_account", bankAccount.Object);
        }
    }
}
