namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class EphemeralKeyTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            var json = GetResourceAsString("api_fixtures.ephemeral_key.json");
            var ephemeralKey = Mapper<EphemeralKey>.MapFromJson(json);

            Assert.NotNull(ephemeralKey);
            Assert.NotNull(ephemeralKey.Id);
            Assert.Equal("ephemeral_key", ephemeralKey.Object);
        }
    }
}
