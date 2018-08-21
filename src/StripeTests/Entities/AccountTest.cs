namespace StripeTests
{
    using System;
    using System.IO;
    using System.Reflection;
    using System.Text;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class AccountTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/accounts/acct_123");
            var account = Mapper<Account>.MapFromJson(json);
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

            string json = GetFixture("/v1/accounts/acct_123", expansions);
            var account = Mapper<Account>.MapFromJson(json);

            Assert.NotNull(account);
            Assert.IsType<Account>(account);
            Assert.NotNull(account.Id);
            Assert.Equal("account", account.Object);

            Assert.NotNull(account.BusinessLogo);
            Assert.Equal("file_upload", account.BusinessLogo.Object);
        }
    }
}
