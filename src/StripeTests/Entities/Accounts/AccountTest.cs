namespace StripeTests
{
    using System.Text.Json;
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
            var account = JsonSerializer.Deserialize<Account>(json);
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
              "settings.branding.icon",
              "settings.branding.logo",
            };

            string json = this.GetFixture("/v1/accounts/acct_123", expansions);
            var account = JsonSerializer.Deserialize<Account>(json);

            Assert.NotNull(account);
            Assert.IsType<Account>(account);
            Assert.NotNull(account.Id);
            Assert.Equal("account", account.Object);

            Assert.NotNull(account.Settings.Branding.Icon);
            Assert.Equal("file", account.Settings.Branding.Icon.Object);

            Assert.NotNull(account.Settings.Branding.Logo);
            Assert.Equal("file", account.Settings.Branding.Logo.Object);
        }
    }
}
