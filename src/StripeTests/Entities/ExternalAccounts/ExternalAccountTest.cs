namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class ExternalAccountTest : BaseStripeTest
    {
        public ExternalAccountTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/accounts/acct_123/external_accounts/ba_123");
            var externalAccount = JsonConvert.DeserializeObject<IExternalAccount>(
                json,
                StripeConfiguration.SerializerSettings);
            Assert.NotNull(externalAccount);
            Assert.IsType<BankAccount>(externalAccount);
            Assert.Equal("bank_account", externalAccount.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "account",
            };

            string json = this.GetFixture("/v1/accounts/acct_123/external_accounts/ba_123", expansions);
            var externalAccount = JsonConvert.DeserializeObject<IExternalAccount>(
                json,
                StripeConfiguration.SerializerSettings);
            Assert.NotNull(externalAccount);
            Assert.IsType<BankAccount>(externalAccount);
            Assert.Equal("bank_account", externalAccount.Object);

            Assert.NotNull(externalAccount.Account);
            Assert.Equal("account", externalAccount.Account.Object);
        }
    }
}
