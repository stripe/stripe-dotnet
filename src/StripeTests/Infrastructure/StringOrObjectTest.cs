namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using Stripe;
    using Stripe.Infrastructure;
    using Xunit;

    public class StringOrObjectTest : BaseStripeTest
    {
        public StringOrObjectTest()
        {
        }

        [Fact]
        public void HandlesObject()
        {
            var json = "{\"id\": \"ch_123\", \"object\": \"charge\"}";
            var value = JObject.Parse(json);

            string id = null;
            Charge charge = null;

            StringOrObject<Charge>.Map(value, s => id = s, o => charge = o);

            Assert.Equal("ch_123", id);
            Assert.Equal("ch_123", charge.Id);
            Assert.Equal("charge", charge.Object);
        }

        [Fact]
        public void HandlesId()
        {
            var value = "ch_123";

            string id = null;
            Charge charge = null;

            StringOrObject<Charge>.Map(value, s => id = s, o => charge = o);

            Assert.Equal("ch_123", id);
            Assert.Null(charge);
        }

        [Fact]
        public void HandlesUnknownObjectWithId()
        {
            var json = "{\"id\": \"foo_123\", \"object\": \"foo\"}";
            var value = JObject.Parse(json);

            string id = null;
            IExternalAccount account = null;

            StringOrObject<IExternalAccount>.Map(value, s => id = s, o => account = o);

            Assert.Equal("foo_123", id);
            Assert.Null(account);
        }

        [Fact]
        public void HandlesUnknownObjectWithoutId()
        {
            var json = "{\"object\": \"bar\"}";
            var value = JObject.Parse(json);

            string id = null;
            IExternalAccount account = null;

            StringOrObject<IExternalAccount>.Map(value, s => id = s, o => account = o);

            Assert.Null(id);
            Assert.Null(account);
        }
    }
}
