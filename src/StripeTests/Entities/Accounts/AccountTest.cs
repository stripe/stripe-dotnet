namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class AccountTest : BaseStripeTest
    {
        public AccountTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/accounts/acct_123");
            var account = JsonConvert.DeserializeObject<Account>(json);
            Assert.NotNull(account);
            Assert.IsType<Account>(account);
            Assert.NotNull(account.Id);
            Assert.Equal("account", account.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "business_logo",
            };

            string json = this.GetFixture("/v1/accounts/acct_123", expansions);
            var account = JsonConvert.DeserializeObject<Account>(json);

            Assert.NotNull(account);
            Assert.IsType<Account>(account);
            Assert.NotNull(account.Id);
            Assert.Equal("account", account.Object);

            Assert.NotNull(account.BusinessLogo);
            Assert.Equal("file", account.BusinessLogo.Object);
        }
    }
}
