namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class IExternalAccountTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/accounts/acct_123/external_accounts/ba_123");
            var externalAccount = Mapper<IExternalAccount>.MapFromJson(json);
            Assert.NotNull(externalAccount);
            Assert.IsType<BankAccount>(externalAccount);
            var bankAccount = (BankAccount)externalAccount;
            Assert.Equal("bank_account", bankAccount.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "account",
            };

            string json = GetFixture("/v1/accounts/acct_123/external_accounts/ba_123", expansions);
            dynamic externalAccount = Mapper<IExternalAccount>.MapFromJson(json);
            Assert.NotNull(externalAccount);
            Assert.IsType<BankAccount>(externalAccount);
            Assert.Equal("bank_account", externalAccount.Object);

            Assert.NotNull(externalAccount.Account);
            Assert.Equal("account", externalAccount.Account.Object);
        }
    }
}
