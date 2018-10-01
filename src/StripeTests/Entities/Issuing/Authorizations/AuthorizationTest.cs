namespace StripeTests.Issuing
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Issuing;
    using Xunit;

    public class AuthorizationTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/issuing/authorizations/iauth_123");
            var authorization = Mapper<Authorization>.MapFromJson(json);
            Assert.NotNull(authorization);
            Assert.IsType<Authorization>(authorization);
            Assert.NotNull(authorization.Id);
            Assert.Equal("issuing.authorization", authorization.Object);

            Assert.NotNull(authorization.Card);
            Assert.Equal("issuing.card", authorization.Card.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "cardholder",
            };

            string json = GetFixture("/v1/issuing/authorizations/iauth_123", expansions);
            var authorization = Mapper<Authorization>.MapFromJson(json);
            Assert.NotNull(authorization);
            Assert.IsType<Authorization>(authorization);
            Assert.NotNull(authorization.Id);
            Assert.Equal("issuing.authorization", authorization.Object);

            Assert.NotNull(authorization.Cardholder);
            Assert.Equal("issuing.cardholder", authorization.Cardholder.Object);
        }
    }
}
