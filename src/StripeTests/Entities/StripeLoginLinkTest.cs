namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class LoginLinkTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            var json = GetResourceAsString("api_fixtures.login_link.json");
            var loginLink = Mapper<LoginLink>.MapFromJson(json);

            Assert.NotNull(loginLink);
            Assert.Equal("login_link", loginLink.Object);
        }
    }
}
