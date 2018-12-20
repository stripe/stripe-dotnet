namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class LoginLinkTest : BaseStripeTest
    {
        public LoginLinkTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            var json = GetResourceAsString("api_fixtures.login_link.json");
            var loginLink = JsonConvert.DeserializeObject<LoginLink>(json);

            Assert.NotNull(loginLink);
            Assert.Equal("login_link", loginLink.Object);
        }
    }
}
