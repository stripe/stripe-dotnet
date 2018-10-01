namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class ExternalAccountTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/accounts/acct_123/external_accounts/ba_123");
            var externalAccount = Mapper<ExternalAccount>.MapFromJson(json);
            Assert.NotNull(externalAccount);
            Assert.Equal(ExternalAccountType.BankAccount, externalAccount.Type);
            Assert.NotNull(externalAccount.BankAccount);
            Assert.Equal("bank_account", externalAccount.BankAccount.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "account",
            };

            string json = GetFixture("/v1/accounts/acct_123/external_accounts/ba_123", expansions);
            var externalAccount = Mapper<ExternalAccount>.MapFromJson(json);
            Assert.NotNull(externalAccount);
            Assert.Equal(ExternalAccountType.BankAccount, externalAccount.Type);
            Assert.NotNull(externalAccount.BankAccount);
            Assert.Equal("bank_account", externalAccount.BankAccount.Object);

            Assert.NotNull(externalAccount.BankAccount.Account);
            Assert.Equal("account", externalAccount.BankAccount.Account.Object);
        }
    }
}
