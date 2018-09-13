namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class TokenTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/tokens/tok_123");
            var token = Mapper<Token>.MapFromJson(json);
            Assert.NotNull(token);
            Assert.IsType<Token>(token);
            Assert.NotNull(token.Id);
            Assert.Equal("token", token.Object);
        }
    }
}
