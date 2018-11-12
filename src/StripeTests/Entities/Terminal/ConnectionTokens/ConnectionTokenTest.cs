namespace StripeTests.Terminal
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Terminal;
    using Xunit;

    public class ConnectionTokenTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            var json = GetResourceAsString("api_fixtures.connection_token.json");
            var connectionToken = Mapper<ConnectionToken>.MapFromJson(json);
            Assert.NotNull(connectionToken);
            Assert.IsType<ConnectionToken>(connectionToken);
            Assert.NotNull(connectionToken.Secret);
            Assert.Equal("terminal.connection_token", connectionToken.Object);
        }
    }
}
